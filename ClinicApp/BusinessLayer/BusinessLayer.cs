using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{

    public class UserInformation
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Hashcode { get; set; }
        public string Role { get; set; }
        public DateTime? DateRetired { get; set; }
    }

    public class ReceptionistInformation
    {
        public int ReceptionistID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PatientInformation
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PESEL { get; set; }
    }

    public class DoctorInformation
    {
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PWZ { get; set; }
    }


    static public class LoginFacade
    {
        public static UserInformation GetUser(String username, String password)
        {
            //Powinna być zamiana password na hash przez funkcje hashujaca - w bazie danych powinien byc hashcode.
            //Do zrobienia.
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.Users
                          where el.Username == username && el.Hashcode == password
                          select new UserInformation
                          { UserID = el.UserID ,Username = el.Username, Hashcode = el.Hashcode, Role = el.Role, DateRetired = el.DateRetired}
                          ).SingleOrDefault();
            return result;   
        }
    }

    static public class DoctorFacade
    {
        public static DoctorInformation GetDoctor(int userID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.Doctors
                          where el.UserID == userID
                          select new DoctorInformation
                          {DoctorID = el.DoctorID, FirstName = el.FirstName, LastName = el.LastName, PWZ = el.PWZNumber }
                          ).SingleOrDefault();
            return result;
        }
    }

    static public class ReceptionistFacade
    {
        public static ReceptionistInformation GetReceptionist(int userID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.Receptionists
                          where el.UserID == userID
                          select new ReceptionistInformation
                          { ReceptionistID = el.ReceptionistID, FirstName = el.FirstName, LastName = el.LastName }
                          ).SingleOrDefault();
            return result;
        }

        public static List<DoctorInformation> GetAllDoctors()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.Doctors
                          select new DoctorInformation
                          {DoctorID = el.DoctorID, FirstName = el.FirstName, LastName = el.LastName, PWZ = el.PWZNumber}
                          ).OrderBy(x => x.LastName).ToList();
            return result;
        }

        public static List<PatientInformation> GetPatients(PatientInformation patientSearchCriteria)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.Patients
                          where 
                          (patientSearchCriteria.FirstName == null || el.FirstName.StartsWith(patientSearchCriteria.FirstName))
                          &&
                          (patientSearchCriteria.LastName == null || el.LastName.StartsWith(patientSearchCriteria.LastName))
                          &&
                          (patientSearchCriteria.PESEL == null || el.PESEL.StartsWith(patientSearchCriteria.PESEL))
                          select new PatientInformation
                          {PatientID = el.PatientID, FirstName = el.FirstName, LastName = el.LastName, PESEL = el.PESEL }
                          ).OrderBy(x => x.LastName).ToList();
            return result;
        }


        public static bool ExistsPatient(PatientInformation pInfo)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var res = (from el in dc.Patients
                       where el.PESEL.Equals(pInfo.PESEL)
                       select el).SingleOrDefault();
            if (res != null)
                return true;
            else
                return false;
        }

        public static void AddNewPatient(PatientInformation pInfo)
        {
            Patient newPatient = new Patient()
            { FirstName = pInfo.FirstName, LastName = pInfo.LastName, PESEL = pInfo.PESEL };
            DataClassesDataContext dc = new DataClassesDataContext();
            dc.Patients.InsertOnSubmit(newPatient);
            dc.SubmitChanges();
        }

        public static void AddNewAppointment(ReceptionistInformation rInfo, PatientInformation pInfo, DoctorInformation dInfo)
        {
            Appointment newAppointment = new Appointment()
            {DoctorID = dInfo.DoctorID, PatientID = pInfo.PatientID, ReceptionistID = rInfo.ReceptionistID,
                DateRegistered = DateTime.Now , Description = "Standard Appointment.", Status = "REG"};
            DataClassesDataContext dc = new DataClassesDataContext();
            dc.Appointments.InsertOnSubmit(newAppointment);
            dc.SubmitChanges();
        }
    }

    static public class LabManagerFacade
    {
        public static LabManager GetLabManager(int userID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.LabManagers
                          where el.UserID == userID
                          select el).SingleOrDefault();
            return result;
        }
    }

    static public class LabTechnicianFacade
    {
        public static LabTechnician GetLabTechnician(int userID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.LabTechnicians
                          where el.UserID == userID
                          select el).SingleOrDefault();
            return result;
        }
    }

    static public class AdminFacade
    {
        public static List<UserInformation> GetUsers(UserInformation userSearchCriteria)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.Users
                          where
                          (userSearchCriteria.UserID == 0 || el.UserID == userSearchCriteria.UserID)
                          &&
                          (userSearchCriteria.Username == null || el.Username.StartsWith(userSearchCriteria.Username))
                          &&
                          (userSearchCriteria.Hashcode == null || el.Hashcode.StartsWith(userSearchCriteria.Hashcode))
                          &&
                          (userSearchCriteria.Role == null || el.Role.StartsWith(userSearchCriteria.Role))
                          select new UserInformation
                          { UserID = el.UserID, Username = el.Username, Hashcode = el.Hashcode, Role = el.Role, DateRetired = el.DateRetired }
                          ).OrderBy(x => x.UserID).ToList();
            return result;
        }
    }

}

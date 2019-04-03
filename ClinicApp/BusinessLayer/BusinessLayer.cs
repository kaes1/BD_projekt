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

    public class LabManagerInformation
    {
        public int LabManagerID { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class LabTechnicianInformation
    {
        public int LabTechnicianID { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class AppointmentInformation
    {
        public int AppointmentID { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public int ReceptionistID { get; set; }
        public string Description { get; set; }
        public string Diagnosis { get; set; }
        public string Status { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public DateTime? DateCompletedOrCanceled { get; set; }
    }

    public class PhysicalExaminationInformation
    {
        public int PhysicalExaminationID { get; set; }
        public int AppointmentID { get; set; }
        public string Code { get; set; }
        public string Result { get; set; }
    }

    public class LabExaminationInformation
    {
        public int LabExaminationID { get; set; }
        public string Code { get; set; }
        public int AppointmentID { get; set; }
        public int LabTechnicianID { get; set; }
        public int LabManagerID { get; set; }
        public DateTime DateRegistered { get; set; }
        public string Result { get; set; }
        public string DoctorComments { get; set; }
        public DateTime? DateCompletedOrCanceled { get; set; }
        public string LabManagerComments { get; set; }
        public DateTime? DateApprovedOrCanceled { get; set; }
        public string Status { get; set; }
    }


    public class ExaminationDictionaryInformation
    {
        public string Code { get; set; }
        public char Type { get; set; }
        public string Name { get; set; }
    }

    public class GeneralExamination
    {
        public DateTime orderDate { get; set; }
        public string examName { get; set; }
        public string state { get; set; }
    }


    //Facade classes
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

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class DoctorAppointment
    {
        public DateTime DateOfAppointment { get; set; }  
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientPesel { get; set; }
        public string Status { get; set; }
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

        public static List<DoctorAppointment> GetAppointmentsForToday(int doctorID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          join pt in dc.Patients on app.PatientID equals pt.PatientID
                          where
                          app.DoctorID == doctorID
                          & app.DateOfAppointment.DayOfYear == DateTime.Now.DayOfYear
                          & app.DateOfAppointment.Year == DateTime.Now.Year
                          select new DoctorAppointment
                          {
                              DateOfAppointment = app.DateOfAppointment,
                              PatientFirstName = pt.FirstName,
                              PatientLastName = pt.LastName,
                              PatientPesel = pt.PESEL,
                              Status = app.Status,
                          }
                          ).ToList();
            return result;
        }

        public static List<DoctorAppointment> GetSearch(DoctorAppointment searchParams, int doctorID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          join pt in dc.Patients on app.PatientID equals pt.PatientID
                          where
                          app.DoctorID == doctorID
                          & pt.FirstName.StartsWith(searchParams.PatientFirstName)
                          & pt.LastName.StartsWith(searchParams.PatientLastName)
                          & pt.PESEL.StartsWith(searchParams.PatientPesel)
                          & app.Status.StartsWith(searchParams.Status)
                          & app.DateOfAppointment.Day == DateTime.Now.Day
                          & app.DateOfAppointment.Year == DateTime.Now.Year
                          & app.DateOfAppointment.Month == DateTime.Now.Month
                          select new DoctorAppointment
                          {
                              DateOfAppointment = app.DateRegistered,
                              PatientFirstName = pt.FirstName,
                              PatientLastName = pt.LastName,
                              PatientPesel = pt.PESEL,
                              Status = app.Status,
                          }
                          ).OrderBy(x => x.DateOfAppointment).ToList();
            return result;
        }

        //TODO zmienic stan wizyty nad zakonczony
        public static void completeAppointment(AppointmentInformation appointment)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            //alter table where app == appointemnt
            //change status, description and diagnosis
            //its already in appointment
        }
        //TODO zmienic wizyte na canceled, brakuje okna do podania powodu odwolania wizyty
        public static void appointmentCanceled(AppointmentInformation actualAppointment)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            Appointment app = new Appointment()
            {
                AppointmentID = actualAppointment.AppointmentID,
                DoctorID = actualAppointment.DoctorID,
                PatientID = actualAppointment.PatientID,
                ReceptionistID = actualAppointment.ReceptionistID,
                Description = actualAppointment.Description,
                Diagnosis = actualAppointment.Diagnosis,
                Status = "CANC",
                DateRegistered = actualAppointment.DateRegistered,
                DateCompletedOrCanceled = DateTime.Today
            };
            dc.Appointments.InsertOnSubmit(app);
            dc.SubmitChanges();
        }

        public static PatientInformation getPatientByPesel(String pesel)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from pt in dc.Patients
                          where pt.PESEL == pesel
                          select new PatientInformation()
                          {
                              FirstName = pt.FirstName,
                              LastName = pt.LastName,
                              PESEL = pt.PESEL,
                              PatientID = pt.PatientID
                          }).ToList();
            return result[0];
        }

        public static AppointmentInformation getAppointmentByPeselAndDate(String pesel,DateTime date)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          join pt in dc.Patients on app.PatientID equals pt.PatientID
                          where app.DateRegistered == date 
                          & pt.PESEL == pesel
                          select new AppointmentInformation()
                          {
                              AppointmentID = app.AppointmentID,
                              DoctorID = app.DoctorID,
                              PatientID = app.PatientID,
                              ReceptionistID = app.ReceptionistID,
                              Description = app.Description,
                              Diagnosis = app.Diagnosis,
                              Status = app.Status,
                              DateRegistered = app.DateRegistered,
                              DateCompletedOrCanceled = app.DateCompletedOrCanceled                        
                          }).SingleOrDefault();
            return result;
        }

       /* public static List<string> getExaminations(String type, int appID)
        {
             DataClassesDataContext dc = new DataClassesDataContext();
             if (type == "LABO")
             {
                 var result = (from ex in dc.LabExaminations
                               join pro in dc.ExaminationDictionaries on ex.ExaminationDictionary equals pro.Code
                               where ex.AppointmentID == appID
                               & ex.DateRegistered.Day == DateTime.Now.Day
                               & ex.DateRegistered.Month == DateTime.Now.Month
                               & ex.DateRegistered.Year == DateTime.Now.Year
                               & pro.Code == ex.procedure)
                     }
           
        }*/
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

        public class CustomAppointment
        {
            public int AppointmentID { get; set; }
            public DateTime DateRegistered { get; set; }
            public DateTime? DateFinalized { get; set; }
            public string Status { get; set; }
            public string DoctorFirstName { get; set; }
            public string DoctorLastName { get; set; }
        }

        public static List<CustomAppointment> GetAppointments(PatientInformation patientInfo)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          join doc in dc.Doctors on app.DoctorID equals doc.DoctorID
                          where
                          app.PatientID == patientInfo.PatientID
                          select new CustomAppointment
                          {
                              AppointmentID = app.AppointmentID,
                              DateRegistered = app.DateRegistered,
                              DateFinalized = app.DateCompletedOrCanceled,
                              Status = app.Status,
                              DoctorFirstName = doc.FirstName,
                              DoctorLastName = doc.LastName,                                                       
                          }
                          ).OrderBy(x => x.DateRegistered).ToList();
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

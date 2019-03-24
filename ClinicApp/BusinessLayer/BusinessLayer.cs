using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{

    static public class RegistrationFacade
    {

        public static IQueryable<Patient> GetPatients()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var res = from el in dc.Patients
                      select el;
            return res;
        }  

    }

    static public class LoginFacade
    {

        public static bool ExistsUser(String username, String password)
        {
            //Powinna być zamiana password na hash przez funkcje hashujaca - w bazie danych powinien byc hashcode.
            //Do zrobienia.
            DataClassesDataContext dc = new DataClassesDataContext();
            bool existsUser = (from el in dc.Users
                          where el.Username == username && el.Hashcode == password
                          select el).Count() == 1;
            return existsUser;
        }

        public static User GetUser(String username, String password)
        {
            //Powinna być zamiana password na hash przez funkcje hashujaca - w bazie danych powinien byc hashcode.
            //Do zrobienia.
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.Users
                          where el.Username == username && el.Hashcode == password
                          select el).SingleOrDefault();
            return result;   
        }
    }

    static public class DoctorFacade
    {
        public static Doctor GetDoctor(int userID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.Doctors
                          where el.UserID == userID
                          select el).SingleOrDefault();
            return result;
        }
    }

    //Klasa Patient na potrzeby wyświetlania informacji w aplikacji (nie do bazy danych).
    public class PatientInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PESEL { get; set; }
    }

    static public class ReceptionistFacade
    {
        public static Receptionist GetReceptionist(int userID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.Receptionists
                          where el.UserID == userID
                          select el).SingleOrDefault();
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
                          { FirstName = el.FirstName, LastName = el.LastName, PESEL = el.PESEL }
                          ).OrderBy(x => x.LastName).ToList();
            return result;
        }

        public static void AddNewPatient(PatientInformation pInfo)
        {
            Patient newPatient = new Patient()
            { FirstName = pInfo.FirstName, LastName = pInfo.LastName, PESEL = pInfo.PESEL };
            DataClassesDataContext dc = new DataClassesDataContext();
            dc.Patients.InsertOnSubmit(newPatient);
            dc.SubmitChanges();
        }

        public static bool ExistsPatient(PatientInformation pInfo)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            //Check if patient already exists.
            var res = (from el in dc.Patients
                       where el.PESEL.Equals(pInfo.PESEL)
                       select el).SingleOrDefault();
            if (res != null)
                return true;
            else
                return false;
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
}

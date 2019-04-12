using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        //Should Role be an enum?
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
        //Should Status be an enum?
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
        //Should Status be an enum?
        public string Status { get; set; }
    }


    public class ExaminationDictionaryInformation
    {
        public string Code { get; set; }
        public char Type { get; set; }
        public string Name { get; set; }
    }

    public class OrderedExamination
    {
        public int ExaminationID { get; set; }
        public string Code { get; set; }
        public string ExamName { get; set; }
        public string Comment { get; set; }
    }


    //Facade classes
    static public class LoginFacade
    {
        public static UserInformation GetUser(String username, String password)
        {
            //Generate hashcode of password.
            var sha256 = new SHA256Managed();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            string hashcode = string.Join(string.Empty, bytes.Select(x => x.ToString("x2")));
            //Get the user.
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from el in dc.Users
                          where el.Username == username && el.Hashcode == hashcode
                          select new UserInformation
                          { UserID = el.UserID ,Username = el.Username, Hashcode = el.Hashcode, Role = el.Role, DateRetired = el.DateRetired}
                          ).SingleOrDefault();
            return result;   
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class DoctorAppointment
    {
        public int AppointmentID { get; set; }
        public DateTime DateOfAppointment { get; set; }  
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientPesel { get; set; }
        public string Status { get; set; }
    }

    public class Examination
    {
        public DateTime dateRegistered { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Result { get; set; }
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
                          ).OrderByDescending(x => x.DateOfAppointment).ToList();
            return result;
        }
        public static List<DoctorAppointment> GetSearchWithoutDate(DoctorAppointment searchParams, int doctorID)
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
                          select new DoctorAppointment
                          {
                              DateOfAppointment = app.DateRegistered,
                              PatientFirstName = pt.FirstName,
                              PatientLastName = pt.LastName,
                              PatientPesel = pt.PESEL,
                              Status = app.Status,
                          }
                          ).OrderByDescending(x => x.DateOfAppointment).ToList();
            return result;
        }

        public static void CompleteAppointment(AppointmentInformation appointment)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          where
                          app.AppointmentID == appointment.AppointmentID
                          select app).Single();
            result.Status = "COMP";
            result.DateCompletedOrCanceled = DateTime.Now;
            dc.SubmitChanges();
        }

        public static void appointmentCanceled(AppointmentInformation actualAppointment)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          where app.AppointmentID == actualAppointment.AppointmentID
                          select app).Single();
            result.DateCompletedOrCanceled = DateTime.Now;
            result.Description = actualAppointment.Description;
            result.Status = "CANC";
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
                          }).SingleOrDefault();
            return result;
        }

        public static AppointmentInformation getAppointmentByPeselAndDate(String pesel, DateTime date)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          join pt in dc.Patients on app.PatientID equals pt.PatientID
                          where app.DateOfAppointment == date
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
                              DateCompletedOrCanceled = app.DateCompletedOrCanceled,
                              DateOfAppointment = app.DateOfAppointment
                          }).SingleOrDefault();
            return result;
        }
        public static List<OrderedExamination> GetTodaysLabExam(AppointmentInformation actApp)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          join lab in dc.LabExaminations on app.AppointmentID equals lab.AppointmentID
                          join dic in dc.ExaminationDictionaries on lab.Code equals dic.Code
                          where
                          app.AppointmentID == actApp.AppointmentID
                          select new OrderedExamination()
                          {
                              ExaminationID = lab.LabExaminationID,
                              Code = lab.Code,
                              ExamName = dic.Name,
                              Comment = lab.DoctorComments
                          }).ToList();
            return result;
        }

        public static List<OrderedExamination> GetTodaysPhysExam(AppointmentInformation actApp)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          join phys in dc.PhysicalExaminations on app.AppointmentID equals phys.AppointmentID
                          join dic in dc.ExaminationDictionaries on phys.Code equals dic.Code
                          where
                          app.AppointmentID == actApp.AppointmentID
                          select new OrderedExamination()
                          {
                              ExaminationID = phys.PhysicalExaminationID,
                              Code = phys.Code,
                              ExamName = dic.Name,
                          }).ToList();
            return result;
        }

        public static List< DoctorAppointment> GetPatientPrevApps(PatientInformation actPat)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          join pt in dc.Patients on app.PatientID equals pt.PatientID
                          where
                          app.DateOfAppointment < DateTime.Now
                          & pt.PatientID == actPat.PatientID
                          & app.Status != "REG"
                          select new DoctorAppointment()
                          {
                              AppointmentID = app.AppointmentID,
                              DateOfAppointment = app.DateOfAppointment,
                              Status = app.Status
                          }).OrderByDescending(x => x.DateOfAppointment).ToList();
            return result;
        }

        public static List<DoctorAppointment> GetPatientPrevExams(PatientInformation actPat)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from pt in dc.Patients
                          join app in dc.Appointments on pt.PatientID equals app.PatientID
                          join phys in dc.PhysicalExaminations on app.AppointmentID equals phys.AppointmentID
                          join lab in dc.LabExaminations on app.AppointmentID equals lab.AppointmentID
                          where
                          app.DateOfAppointment < DateTime.Now
                          & pt.PatientID == actPat.PatientID
                          & app.Status != "REG"
                          select new DoctorAppointment()
                          {
                              AppointmentID = app.AppointmentID,
                              DateOfAppointment = app.DateOfAppointment,
                              Status = app.Status
                          }).OrderByDescending(x => x.DateOfAppointment).ToList();
            return result;
        }

        public static AppointmentInformation GetActAppInfo(AppointmentInformation actApp)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          where app.AppointmentID == actApp.AppointmentID
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
                              DateCompletedOrCanceled = app.DateCompletedOrCanceled,
                              DateOfAppointment = app.DateOfAppointment
                          }).SingleOrDefault();
            return result;
        }

        public static void SetAppStatus(AppointmentInformation actApp, String stat)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          where app.AppointmentID == actApp.AppointmentID
                          select app).Single();
            result.Status = stat;
            dc.SubmitChanges();
        }

        public static List<ExaminationDictionaryInformation> GetPhysExam(String exName, String exCode)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from dic in dc.ExaminationDictionaries
                          where
                          dic.Type == 'P'
                          & dic.Name.StartsWith(exName)
                          & dic.Code.StartsWith(exCode)
                          select new ExaminationDictionaryInformation()
                          {
                              Code = dic.Code,
                              Name = dic.Name
                          }).ToList();
            return result;
        }

        public static List<ExaminationDictionaryInformation> GetLabExam(String exName, String exCode)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from dic in dc.ExaminationDictionaries
                          where
                          dic.Type == 'L'
                          & dic.Name.StartsWith(exName)
                          & dic.Code.StartsWith(exCode)
                          select new ExaminationDictionaryInformation()
                          {
                              Code = dic.Code,
                              Name = dic.Name
                          }).ToList();
            return result;
        }

        public static void updateDescription(AppointmentInformation actApp, String desc)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          where app.AppointmentID == actApp.AppointmentID
                          select app).Single();
            result.Description = desc;
            dc.SubmitChanges();
        }
        public static void updateDiagnosis(AppointmentInformation actApp, String diag)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          where app.AppointmentID == actApp.AppointmentID
                          select app).Single();
            result.Diagnosis = diag;
            dc.SubmitChanges();
        }

        public static List<ExaminationDictionaryInformation> GetDictPhysExams(ExaminationDictionaryInformation patternExam)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from phys in dc.ExaminationDictionaries
                          where
                          phys.Code.StartsWith(patternExam.Code)
                          & phys.Name.StartsWith(patternExam.Name)
                          & phys.Type == 'P'
                          select new ExaminationDictionaryInformation
                          {
                              Code = phys.Code,
                              Name = phys.Name
                          }).ToList();
            return result;
        }
        public static List<ExaminationDictionaryInformation> GetDictLabExams(ExaminationDictionaryInformation patternExam)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from lab in dc.ExaminationDictionaries
                          where
                          lab.Code.StartsWith(patternExam.Code)
                          & lab.Name.StartsWith(patternExam.Name)
                          & lab.Type == 'L'
                          select new ExaminationDictionaryInformation
                          {
                              Code = lab.Code,
                              Name = lab.Name
                          }).ToList();
            return result;
        }
        
        public static void AddPhysExamination(int appID, String examCode, String examResult)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            PhysicalExamination phys = new PhysicalExamination()
            {
                AppointmentID = appID,
                Code = examCode,
                Result = examResult,
                
            };          
            dc.PhysicalExaminations.InsertOnSubmit(phys);
            dc.SubmitChanges();
        }

        public static void AddLabExamination(int appID, String examCode, String examComment)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            LabExamination lab = new LabExamination()
            {
                AppointmentID = appID,
                Code = examCode,
                DoctorComments = examComment,
                DateRegistered = DateTime.Now,
                Status = "REG"

            };
            dc.LabExaminations.InsertOnSubmit(lab);
            dc.SubmitChanges();
        }
        public static AppointmentInformation GetAppointmentByID(int appID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          where app.AppointmentID == appID
                          select new AppointmentInformation
                          {
                              Description = app.Description
                          }).Single();
            return result;
        }
        public static PhysicalExaminationInformation GetPhysicalExamination(int examID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from phys in dc.PhysicalExaminations
                          where
                          phys.PhysicalExaminationID == examID
                          select new PhysicalExaminationInformation()
                          {
                              AppointmentID = phys.AppointmentID,
                              Code = phys.Code,
                              PhysicalExaminationID = phys.PhysicalExaminationID,
                              Result = phys.Result
                          }).Single();
            return result;
        }
        public static LabExaminationInformation GetLaboratoryExamination(int examID)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from lab in dc.LabExaminations
                          where
                          lab.LabExaminationID == examID
                          select new LabExaminationInformation()
                          {
                              AppointmentID = lab.AppointmentID,
                              Code = lab.Code,
                              DateApprovedOrCanceled = lab.DateApprovedOrCanceled,
                              DateCompletedOrCanceled = lab.DateCompletedOrCanceled,
                              DateRegistered = lab.DateRegistered,
                              DoctorComments = lab.DoctorComments,
                              LabExaminationID = lab.LabExaminationID,
                              LabManagerComments = lab.LabManagerComments,
                              Result = lab.Result,
                              Status = lab.Status
                          }).Single();
            return result;
        }
        public static List<Examination> GetPreviousExaminations(PatientInformation actPat)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var labex = (from pat in dc.Patients
                          join app in dc.Appointments on pat.PatientID equals app.PatientID
                          join lx in dc.LabExaminations on app.AppointmentID equals lx.AppointmentID
                          join dic in dc.ExaminationDictionaries on lx.Code equals dic.Code
                          where
                          pat.PatientID == actPat.PatientID
                          & lx.DateRegistered.Date < DateTime.Now.Date
                          select new Examination
                          {
                              dateRegistered = lx.DateRegistered,
                              Code = lx.Code,
                              Name = dic.Code,
                              Result = lx.Result,
                              Status = lx.Status
                          }).ToList();
            var physex = (from pat in dc.Patients
                      join app in dc.Appointments on pat.PatientID equals app.PatientID
                      join lx in dc.PhysicalExaminations on app.AppointmentID equals lx.AppointmentID
                      join dic in dc.ExaminationDictionaries on lx.Code equals dic.Code
                      where
                      pat.PatientID == actPat.PatientID
                      & app.DateOfAppointment.Date < DateTime.Now.Date
                      select new Examination
                      {
                          dateRegistered = app.DateOfAppointment,
                          Code = lx.Code,
                          Name = dic.Code,
                          Result = lx.Result,
                          Status = "COMP"
                      }).ToList();
            var result = labex;
            foreach(var res in physex)
            {
                result.Add(res);
            }
            return result;
        }

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
                          { PatientID = el.PatientID, FirstName = el.FirstName, LastName = el.LastName, PESEL = el.PESEL }
                          ).OrderBy(x => x.LastName).ToList();
            return result;
        }

        public class ReceptionistAppointment
        {
            public DateTime? Date { get; set; }
            public string Status { get; set; }
            public string DoctorFirstName { get; set; }
            public string DoctorLastName { get; set; }
            public int AppointmentID { get; set; }
        }

        public static List<ReceptionistAppointment> GetAppointments(PatientInformation patientInfo, DateTime? appointmentDate, string status, string doctorLastName)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from app in dc.Appointments
                          join doc in dc.Doctors on app.DoctorID equals doc.DoctorID
                          where
                          app.PatientID == patientInfo.PatientID
                          &&
                          (appointmentDate == null || app.DateOfAppointment.Date == appointmentDate.GetValueOrDefault().Date)
                          &&
                          (string.IsNullOrWhiteSpace(status) || app.Status.StartsWith(status))
                          &&
                          (doctorLastName == null || doc.LastName.StartsWith(doctorLastName))
                          select new ReceptionistAppointment
                          {
                              AppointmentID = app.AppointmentID,
                              Date = app.DateOfAppointment,
                              Status = app.Status,
                              DoctorFirstName = doc.FirstName,
                              DoctorLastName = doc.LastName,
                          }
                          ).OrderByDescending(x => x.Date).ToList();
            return result;
        }

        public static List<TimeSpan> GetAppointmentTimes(DoctorInformation doctorInformation, DateTime appointmentDate)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            //Get
            var result = (from app in dc.Appointments
                          where
                          app.DoctorID == doctorInformation.DoctorID
                          &&
                          app.Status != "CANC"
                          &&
                          app.DateOfAppointment.Date == appointmentDate.Date
                          select app.DateOfAppointment.TimeOfDay
                          ).OrderBy(x => x).ToList();

            return result;
        }

        public static List<DoctorInformation> GetDoctors(DoctorInformation doctorSearchCriteria)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from d in dc.Doctors
                          where
                          (doctorSearchCriteria.FirstName == null || d.FirstName.StartsWith(doctorSearchCriteria.FirstName))
                          &&
                          (doctorSearchCriteria.LastName == null || d.LastName.StartsWith(doctorSearchCriteria.LastName))
                          select new DoctorInformation
                          { DoctorID = d.DoctorID, FirstName = d.FirstName, LastName = d.LastName, PWZ = d.PWZNumber }
                          ).OrderBy(x => x.LastName).ToList();
            return result;
        }

        public static bool ExistsPatient(PatientInformation patientInformation)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var res = (from el in dc.Patients
                       where el.PESEL.Equals(patientInformation.PESEL)
                       select el).SingleOrDefault();
            if (res != null)
                return true;
            else
                return false;
        }

        public static void ChangePatientInfo(PatientInformation patientInformation, string newFirstName, string newLastName)
        {
            //Get Patient from database.
            DataClassesDataContext dc = new DataClassesDataContext();
            var patient = (from p in dc.Patients
                           where p.PatientID == patientInformation.PatientID
                           select p).SingleOrDefault();

            //Change hashcode.
            patient.FirstName = newFirstName;
            patient.LastName = newLastName;
            dc.SubmitChanges();
        }

        public static void CancelAppointment(int appointmentID)
        {
            //Get Appointment from database.
            DataClassesDataContext dc = new DataClassesDataContext();
            var appointment = (from app in dc.Appointments
                               where app.AppointmentID == appointmentID
                               select app).SingleOrDefault();
            //Change status.
            appointment.Status = "CANC";
            dc.SubmitChanges();
        }

        public static void AddPatient(PatientInformation patientInformation)
        {
            Patient newPatient = new Patient()
            { FirstName = patientInformation.FirstName, LastName = patientInformation.LastName, PESEL = patientInformation.PESEL };
            DataClassesDataContext dc = new DataClassesDataContext();
            dc.Patients.InsertOnSubmit(newPatient);
            dc.SubmitChanges();
        }

        public static void AddAppointment(ReceptionistInformation receptionistInformation, PatientInformation patientInformation, DoctorInformation doctorInformation, DateTime appointmentDate)
        {
            Appointment newAppointment = new Appointment()
            {
                DoctorID = doctorInformation.DoctorID,
                PatientID = patientInformation.PatientID,
                ReceptionistID = receptionistInformation.ReceptionistID,
                DateRegistered = DateTime.Now,
                DateOfAppointment = appointmentDate,
                Description = "Standard Appointment.",
                Status = "REG"
            };
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
        public static List<UserInformation> GetUsers(UserInformation userSearchCriteria, bool onlyActive = false)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from u in dc.Users
                          where
                          (userSearchCriteria.UserID == 0 || u.UserID == userSearchCriteria.UserID)
                          &&
                          (userSearchCriteria.Username == null || u.Username.StartsWith(userSearchCriteria.Username))
                          &&
                          (userSearchCriteria.Hashcode == null || u.Hashcode.StartsWith(userSearchCriteria.Hashcode))
                          &&
                          (userSearchCriteria.Role == null || u.Role.StartsWith(userSearchCriteria.Role))
                          &&
                          (userSearchCriteria.DateRetired == null || (u.DateRetired.HasValue && u.DateRetired.Value.Date == userSearchCriteria.DateRetired))
                          &&
                          (onlyActive == false || u.DateRetired.HasValue == false || u.DateRetired.Value.Date > DateTime.Now)
                          select new UserInformation
                          { UserID = u.UserID, Username = u.Username, Hashcode = u.Hashcode, Role = u.Role, DateRetired = u.DateRetired }
                          ).OrderBy(x => x.UserID).ToList();
            return result;
        }

        public static bool ExistsUser(string username)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var result = (from u in dc.Users
                          where
                          u.Username == username
                          select u).SingleOrDefault();
            if (result != null)
                return true;
            else
                return false;
        }

        public static void ChangeUserPassword(int userID, string newPassword)
        {
            //Generate hashcode of password.
            var sha256 = new SHA256Managed();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(newPassword));
            string newHashcode = string.Join(string.Empty, bytes.Select(x => x.ToString("x2")));

            //Get User from database.
            DataClassesDataContext dc = new DataClassesDataContext();
            var user = (from u in dc.Users
                         where u.UserID == userID
                         select u).SingleOrDefault();

            //Change hashcode.
            user.Hashcode = newHashcode;
            dc.SubmitChanges();
        }

        public static void ChangeUserDateRetired(int userID, DateTime? newDateRetired)
        {
            //Get User from database.
            DataClassesDataContext dc = new DataClassesDataContext();
            var user = (from u in dc.Users
                        where u.UserID == userID
                        select u).SingleOrDefault();
            //Change DateRetired.
            user.DateRetired = newDateRetired;
            dc.SubmitChanges();
        }

        public static void AddUser(string username, string password, string role, string firstName, string lastName, int PWZNumber)
        {
            
            //Generate hashcode of password.
            var sha256 = new SHA256Managed();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            string hashcode = string.Join(string.Empty, bytes.Select(x => x.ToString("x2")));

            //Create new User
            User newUser = new User()
            {
                Username = username.ToLower(),
                Hashcode = hashcode,
                Role = role,
                DateRetired = null
            };

            DataClassesDataContext dc = new DataClassesDataContext();
            dc.Users.InsertOnSubmit(newUser);

            //Create new class based on role.
            switch (role)
            {
                case "REC":
                    Receptionist newReceptionist = new Receptionist()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        User = newUser
                    };
                    dc.Receptionists.InsertOnSubmit(newReceptionist);
                    break;
                case "DOC":
                    Doctor newDoctor = new Doctor()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        User = newUser,
                        PWZNumber = PWZNumber
                    };
                    dc.Doctors.InsertOnSubmit(newDoctor);
                    break;
                case "TEC":
                    LabTechnician newLabTechnician = new LabTechnician()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        User = newUser
                    };
                    dc.LabTechnicians.InsertOnSubmit(newLabTechnician);
                    break;
                case "MAN":
                    LabManager newLabManager = new LabManager()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        User = newUser
                    };
                    dc.LabManagers.InsertOnSubmit(newLabManager);
                    break;
                case "ADM":
                    break;
            }

            dc.SubmitChanges();
        }

        public static bool ValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            if (password.Length < 4)
                return false;

            return true;
        }

        public static string PasswordRequirements = " - at least 4 characters long.";

    }
}

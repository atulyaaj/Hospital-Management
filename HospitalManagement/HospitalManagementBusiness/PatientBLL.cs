using HospitalManagementData;
using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBusiness
{
    public class PatientBLL
    {
        public bool PatientLogin(string patientEmail, string patientPassword)
        {
            PatientDAL userDAL = new PatientDAL();
            List<Patient> patients = userDAL.GetAllPatientsDAL();
            bool flag = false;
            foreach (var item in patients)
            {
                if (item.PatientEmail == patientEmail && item.PatientPassword == patientPassword)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public string AddPatientBLL(Patient patient)
        {
            PatientDAL patientDAL = new PatientDAL();
            return patientDAL.AddPatientsDAL(patient);
        }
        public string RemovePatientBLL(Patient patient)
        {
            PatientDAL patientDAL = new PatientDAL();
            return patientDAL.RemovePatientsDAL(patient);
        }
        public string UpdatePatientBLL(Patient patient)
        {
            PatientDAL patientDAL = new PatientDAL();
            return patientDAL.UpdatePatientsDAL(patient);
        }
        public List<Appointment> GetPatientAppointmentBLL()
        {
            PatientDAL patientDAL = new PatientDAL();
            return patientDAL.GetPatientsAppointmentDAL();
        }

    }
}

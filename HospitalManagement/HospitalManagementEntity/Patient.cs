using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementEntity
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientDob { get; set; }
        public int PatientAge { get; set; }
        public string PatientSex { get; set; }
        public string PatientMobile { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPassword { get; set; }

        public Patient(int patientId, string patientName, string patientDob, int patientAge, string patientSex, string patientMobile, string patientEmail, string patientPassword)
        {
            this.PatientId = patientId;
            this.PatientName = patientName;
            this.PatientDob = patientDob;
            this.PatientAge = patientAge;
            this.PatientSex = patientSex;
            this.PatientMobile = patientMobile;
            this.PatientEmail = patientEmail;
            this.PatientPassword = patientPassword;
        }
        public Patient()
        {

        }
    }
}

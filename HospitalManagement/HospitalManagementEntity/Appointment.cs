using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementEntity
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string AppointedRoom { get; set; }
        public string AppointmentDate { get; set; }
        public int PatientId { get; set; }

        public Appointment(int appointmentId, string appointedRoom, string appointmentDate, int patientId)
        {
            this.AppointmentId = appointmentId;
            this.AppointedRoom = appointedRoom;
            this.AppointmentDate = appointmentDate;
            this.PatientId = patientId;
        }
        public Appointment()
        {

        }
    }
}

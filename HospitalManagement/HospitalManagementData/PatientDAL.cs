using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementEntity;

namespace HospitalManagementData
{
    public class PatientDAL
    {
        public static string sqlcon = "Data Source=VDC01LTC2125;Initial Catalog=HospitalManagement;Integrated Security=True;";
        public List<Patient> patients = new List<Patient>();

        public List<Patient> GetAllPatientsDAL()
        {
            patients = new List<Patient>
            {
                new Patient(2,"Anuj","Sept 25",25,"M","9304352518","abc@gmail.com","anuj"),
                new Patient(3,"Ritik","Oct 25",29,"M","9306002518","xyz@gmail.com","ritik")
            };
            return patients;
        }
        public string AddPatientsDAL(Patient patient)
        {
            #region disconnected approach
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("insert into patient values(" + patient.PatientId + ",'" + patient.PatientName + "','" + patient.PatientDob + "'," + patient.PatientAge + ",'" + patient.PatientSex + "','" + patient.PatientMobile + "','" + patient.PatientEmail + "','" + patient.PatientPassword + "')", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return "";
            #endregion
        }
        public string RemovePatientsDAL(Patient patient)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("delete from patient where patientid=" + patient.PatientId + "", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return "";
        }
        public string UpdatePatientsDAL(Patient patient)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("update patient set patientid=" + patient.PatientId + ",patientname='" + patient.PatientName + "',patientdob='" + patient.PatientDob + "',patientage=" + patient.PatientAge + ",patientsex='" + patient.PatientSex + "',patientmobile='" + patient.PatientMobile + "',patientemail='" + patient.PatientEmail + "',patientpassword='" + patient.PatientPassword + "'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return "";
        }
        public List<Appointment> GetPatientsAppointmentDAL()
        {

            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("select * from appointment", con);
            DataTable dt = new DataTable();
            List<Appointment> appointments = new List<Appointment>();
            adp.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    appointments.Add(new Appointment
                    {
                        AppointmentId = Convert.ToInt32(dt.Rows[i]["AppointmentId"]),
                        AppointedRoom = dt.Rows[i]["AppointedRoom"].ToString(),
                        AppointmentDate = dt.Rows[i]["AppointmentDate"].ToString(),
                        PatientId = Convert.ToInt32(dt.Rows[i]["PatientId"])
                    });
                }
            }

            return appointments;
        }

    }
}

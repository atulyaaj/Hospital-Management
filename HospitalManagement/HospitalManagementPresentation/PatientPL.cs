using HospitalManagementBusiness;
using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementPresentation
{
    public class PatientPL
    {
        Patient patient = null;
        Appointment appointment=null;
        public void PatientLogin()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Patient-Login-----------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Email Id: ");
            string patientEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Password: ");
            string patientPass = Console.ReadLine();
            PatientBLL patientBLL = new PatientBLL();
            bool status = patientBLL.PatientLogin(patientEmail, patientPass);
            if (status)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in successfully...");
                PatientSection();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid credentials");
            }

        }
        
        public string AddPatient()
        {
            patient = new Patient();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Patient Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Patient Id: ");
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Patient Name: ");
            patient.PatientName = Console.ReadLine();
            Console.Write("DOB: ");
            patient.PatientDob = Console.ReadLine();
            Console.Write("Age: ");
            patient.PatientAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sex: ");
            patient.PatientSex = Console.ReadLine();
            Console.Write("Mobile No.: ");
            patient.PatientMobile = Console.ReadLine();
            Console.Write("Email: ");
            patient.PatientEmail = Console.ReadLine();
            Console.Write("Password: ");
            patient.PatientPassword = Console.ReadLine();
            PatientBLL patientBLL = new PatientBLL();
            string msg = patientBLL.AddPatientBLL(patient);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your appointment is scheduled...");
            return msg;
        }
        public void PatientSection()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Patient-Section----------------");
            GetPatientMenu();
            int inputCaseBook = int.Parse(Console.ReadLine());
            switch (inputCaseBook)
            {
                case 1:
                    AddPatient();
                    PatientSection();
                    break;
                case 2:
                    UpdatePatient();
                    PatientSection();
                    break;
                case 3:
                    RemovePatient();
                    PatientSection();
                    break;
                case 4:
                    GetAppointment();
                    PatientSection();
                    break;
                case 5:
                    break;
            }
        }
        private void GetPatientMenu()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1) Press 1 to schedule an appointment\n" +
               "2) Press 2 to update a patient details\n" +
               "3) Press 3 to cancel an appointment\n" +
               "4) Press 4 to show appointment details\n"+
               "5) Press 5 to exit\n");
        }
        private string RemovePatient()
        {
            patient = new Patient();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Patient Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Patient Id: ");
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            PatientBLL patientBLL = new PatientBLL();
            string msg = patientBLL.RemovePatientBLL(patient);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Appointment Cancelled Successfully...");
            return "";

        }
        private string UpdatePatient()
        {
            patient = new Patient();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Patient Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Patient Id: ");
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Patient Name: ");
            patient.PatientName = Console.ReadLine();
            Console.Write("DOB: ");
            patient.PatientDob = Console.ReadLine();
            Console.Write("Age: ");
            patient.PatientAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sex: ");
            patient.PatientSex = Console.ReadLine();
            Console.Write("Mobile No.: ");
            patient.PatientMobile = Console.ReadLine();
            Console.Write("Email: ");
            patient.PatientEmail = Console.ReadLine();
            Console.Write("Password: ");
            patient.PatientPassword = Console.ReadLine();
            PatientBLL patientBLL = new PatientBLL();
            string msg = patientBLL.UpdatePatientBLL(patient);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Patient Details Updated Successfully...");
            return msg;
        }
        public void GetAppointment()
        {
            appointment = new Appointment();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------Appointment-List----------------------------");
            Console.WriteLine("--Appointment-Id--------Room-No------Appointment-Date---------Patient-Id---------");
            Console.ForegroundColor = ConsoleColor.White;
            PatientBLL patientBLL = new PatientBLL();
            List<Appointment> appointmentBLLList = new List<Appointment>();
            appointmentBLLList = patientBLL.GetPatientAppointmentBLL();
            foreach (var item in appointmentBLLList)
            {
                Console.WriteLine(item.AppointmentId + "\t\t\t" + item.AppointedRoom + "\t\t" + item.AppointmentDate + "\t\t\t" + item.PatientId);

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}

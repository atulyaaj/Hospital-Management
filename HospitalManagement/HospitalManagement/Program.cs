using HospitalManagementPresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Alpha Hospital Management System");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to login as Admin\n" +
            "2) Press 2 to login as Patient\n" +
            "3) Press 3 to login as Doctor\n" +
            "4) Press 4 to exit");

            int inputCase = int.Parse(Console.ReadLine());
            switch (inputCase)
            {
                case 1:
                    break;
                case 2:
                    PatientPL patientPL = new PatientPL();
                    patientPL.PatientLogin();
                    break;
                case 3:
                    break;
                case 4:
                    break;

            }
            Console.Read();

        }
    }
}

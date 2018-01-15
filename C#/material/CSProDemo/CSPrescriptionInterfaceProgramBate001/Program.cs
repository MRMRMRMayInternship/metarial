﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPrescriptionInterfaceProgramBate001
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                /******** 1 login form *******/
                Views.LoginForm loginForm = new Views.LoginForm();
                loginForm.FeedbackEventHandle = LoginFeedback;
                loginForm.ShowDialog();
                if (loginForm.DialogResult == DialogResult.OK)
                {
                    Views.PrescriptionInterfaceForm prescriptionInterfaceForm = new Views.PrescriptionInterfaceForm();
                   
                    prescriptionInterfaceForm.DoctorInfomation = doctor;
                    prescriptionInterfaceForm.InitializeDoctorInformation();
                    //prescriptionInterfaceForm.DoctorInfomation = doctor;
                    Application.Run(prescriptionInterfaceForm);
                    if (prescriptionInterfaceForm.IsExit) break;
                }
                else
                {
                    break;
                }
            }
        }
        private static Models.DoctorClass doctor;
        private static void LoginFeedback(Models.DoctorClass obj)
        {
            doctor = obj;
        }
        private static Models.DoctorClass ValidateLogin(string ID = null, string password = null)
        {
            Models.DoctorClass doctor = new Models.DoctorClass();
            doctor.Name = "신라";
            doctor.ID = "D100171227173011";
            doctor.Department = "내과";
            doctor.Age = null;
            doctor.Birthday = null;
            doctor.Sex = null;
            doctor.ResidentRegistrationNumber = null;
            doctor.Password = null;
            return doctor;
        }
    }
}

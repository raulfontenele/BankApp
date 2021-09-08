using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

using BankApp.View;


namespace BankApp.Controller
{
    public static class IndexController
    {
        private static Form _parentForm;
        private static Form CurrentForm;
        private static List<Form> oppenedForms = new List<Form>();

        private static string _panelName = "";

        public static Form ParentForm { get => _parentForm; set => _parentForm = value; }
        public static string PanelName { get => _panelName; set => _panelName = value; }


        public static void Action(string formOption)
        {
            try
            {
                string methodString = String.Concat("Action_", formOption);
                Type type = typeof(IndexController);
                MethodInfo method = type.GetMethod(methodString, BindingFlags.NonPublic | BindingFlags.Static);
                method.Invoke(null, null);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }
        private static void Action_Login()
        {
            int index = IndexFormList("LoginForm");
            Form loginForm;
            if (index != -1)
            {
                loginForm = oppenedForms[index];
            }
            else
            {
                loginForm = new LoginForm();
                oppenedForms.Add(loginForm);
            }
            Render(loginForm);

        }
        private static void Action_Registration()
        {
            int index = IndexFormList("Registration");
            Form registration;
            if (index != -1)
            {
                registration = oppenedForms[index];
            }
            else
            {
                registration = new RegistrationForm();
                oppenedForms.Add(registration);
            }
            Render(registration);

        }
        private static void Action_Account()
        {
            int index = IndexFormList("AccountForm");
            Form accountForm;
            if (index != -1)
            {
                accountForm = oppenedForms[index];
            }
            else
            {
                accountForm = new AccountForm();
                oppenedForms.Add(accountForm);
            }
            Render(accountForm);
            CurrentForm = null;

        }
        private static void Action_Removal()
        {
            int index = IndexFormList("Removal");
            Form removelForm;
            if (index != -1)
            {
                removelForm = oppenedForms[index];
            }
            else
            {
                removelForm = new RemovelForm();
                oppenedForms.Add(removelForm);
            }
            Render(removelForm);
        }
        private static void Action_Statement()
        {
            int index = IndexFormList("Statement");
            Form statementForm;
            if (index != -1)
            {
                statementForm = oppenedForms[index];
            }
            else
            {
                statementForm = new StatementForm();
                oppenedForms.Add(statementForm);
            }
            Render(statementForm);
        }

        private static Label CreateLabel(string message)
        {
            Label label = new Label();
            label.Text = message;
            label.Dock = DockStyle.Fill;
            label.AutoSize = false;
            label.Font = new Font("Calibri", 18);
            label.ForeColor = Color.Snow;
            label.TextAlign = ContentAlignment.MiddleCenter;

            return label;
        }
        private static int IndexFormList(string formName)
        {
            int indexScreen = -1;

            for (int index = 0; index < oppenedForms.Count; index++)
            {
                if (oppenedForms[index].Name == String.Concat(formName, "Form")) return index;
            }
            return indexScreen;
        }

        static void Render(Form formChild)
        {
            try
            {
                if (formChild == CurrentForm) return;
                else if (CurrentForm != null)
                {
                    CurrentForm.Hide();
                }
                Control panelContent = ParentForm.Controls[_panelName];

                formChild.TopLevel = false;
                formChild.FormBorderStyle = FormBorderStyle.None;
                formChild.Dock = DockStyle.Fill;

                panelContent.Controls.Add(formChild);
                panelContent.Tag = formChild;
                formChild.BringToFront();
                formChild.Show();

                CurrentForm = formChild;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }


        }
    }
}

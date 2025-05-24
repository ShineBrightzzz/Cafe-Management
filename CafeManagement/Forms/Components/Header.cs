using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Controllers;
using CafeManagement.Entities;

namespace CafeManagement.Forms
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
            this.HandleCreated += Header_HandleCreated;
        }

        private void Header_HandleCreated(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            try
            {
                // Ensure we're running on the UI thread
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(LoadUserInfo));
                    return;
                }

                // Get current Form instance
                Form currentForm = this.FindForm();
                  // If the form is FormMain or OrderForm
                if (currentForm is FormMain mainForm)
                {
                    Account currentAccount = mainForm.CurrentAccount;
                    if (currentAccount != null)
                    {
                        lblUsername.Text = currentAccount.getUsername();
                        lblUsername.ForeColor = Color.White;
                    }
                    else
                    {
                        Console.WriteLine("CurrentAccount is null");
                    }
                }
                else if (currentForm is OrderForm orderForm)
                {
                    Account currentAccount = orderForm.CurrentAccount;
                    if (currentAccount != null)
                    {
                        lblUsername.Text = currentAccount.getUsername();
                        lblUsername.ForeColor = Color.White;
                    }
                    else
                    {
                        Console.WriteLine("CurrentAccount is null in OrderForm");
                    }
                }
                else
                {
                    Console.WriteLine("Current form is not FormMain");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadUserInfo: {ex.Message}");
            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            // Find the parent form
            Form currentForm = this.FindForm();
            if (currentForm != null)
            {
                currentForm.Close();
                // Create and show the login form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}

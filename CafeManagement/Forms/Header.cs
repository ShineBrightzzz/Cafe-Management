using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Forms
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
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
                
                // Close the current form
                
            }
        }
    }
}

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
            Form currentForm = this.FindForm();
            if (currentForm != null)
            {
                currentForm.Controls.Clear();
            }
            LoginForm loginForm = new LoginForm();
            loginForm.ShowLoginControls();
        }
    }
}

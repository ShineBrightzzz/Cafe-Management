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
using CafeManagement.Utils;

namespace CafeManagement.Forms
{
    public partial class RegisterPanel : UserControl
    {

        private readonly AccountController controller;
        public RegisterPanel()
        {
            InitializeComponent();
            lblLetsLogin.Click += LblLetsLogin_Click;
            btnRegister.Click += btnRegister_Click;

            cboRole.Items.Add("Admin");
            cboRole.Items.Add("Employee");

            controller = new AccountController();
        }
    
    
    private void LblLetsLogin_Click(object sender, EventArgs e)
        {
            // Gọi phương thức ở LoginForm để hiển thị lại giao diện đăng nhập
            var parentForm = this.ParentForm as LoginForm;
            if (parentForm != null)
            {
                parentForm.ShowLoginControls();
            }
        }
    

    private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtEmployeeId.Text == "" || txtUsernameRe.Text == "" || txtPasswordRe.Text == "" || cboRole.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            string id = GenerateUUID.Generate();
            string employeeId = txtEmployeeId.Text;
            string user = txtUsernameRe.Text;
            string pass = txtPasswordRe.Text;
            string role = cboRole.Text;

            if (controller.Register(id, employeeId, user, pass, role))
                MessageBox.Show("Đăng ký thành công!");
            else
                MessageBox.Show("Đăng ký thất bại.");
        }
    }
}
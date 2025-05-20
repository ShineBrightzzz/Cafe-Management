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

namespace CafeManagement.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AccountController controller;


        public LoginForm()
        {
            InitializeComponent();
            controller = new AccountController();
        }


        public void ShowLoginControls()
        {
            MainPanel.Controls.Clear();

            // Thêm lại các control đăng nhập trực tiếp
            txtUsername.Text = "";
            txtPassword.Text = "";

            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(txtUsername);
            MainPanel.Controls.Add(txtPassword);
            MainPanel.Controls.Add(btnLogin);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.");
                return;
            }
            if (txtPassword.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                return;
            }

            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            if (controller.Login(user, pass))
            {
                var account = controller.GetAccount(user); // ✅ Lấy thông tin tài khoản
                if (account.getRole() == "Admin")
                {
                    MessageBox.Show("Đăng nhập với quyền Admin");
                    FormMain mainForm = new FormMain();
                    mainForm.Show();
                    this.Hide();
                }
                else if (account.getRole() == "Employee")
                {
                    MessageBox.Show("Đăng nhập với quyền Nhân viên");
                    OrderForm orderForm = new OrderForm();
                    orderForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không xác định quyền.");
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Forms.Employee
{
    public partial class EmployeePanel : UserControl
    {
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNV addEmployee = new ThemNV();
            addEmployee.Show();
        }
    }
}

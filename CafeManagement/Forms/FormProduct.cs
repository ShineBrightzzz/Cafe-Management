using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Database;

namespace CafeManagement.Forms
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            DBConnect.GetConnection();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

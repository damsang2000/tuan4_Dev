using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamTanSang_2001180119_Tuan4
{
    public partial class frCauHinh : Form
    {
        QL_Nguoidung cauhinh = new QL_Nguoidung();
        public frCauHinh()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            
        }
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frCauHinh_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = cauhinh.GetServerName();
            comboBox1.DisplayMember = "ServerName";
            comboBox2.DataSource = cauhinh.GetDBName(comboBox1.Text, textBox1.Text, textBox2.Text);
            comboBox2.DisplayMember = "Name";
        }

       
    }
}

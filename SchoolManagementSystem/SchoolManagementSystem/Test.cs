using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Test : Form
    {
        private DataSet Ds { get; set; }
        public Test()
        {
            InitializeComponent();

            
        }

        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string sql = "SELECT * FROM STUDENT_COURSE WHERE ST_ID='10002'";
            DataSet ds = DataAccess.ExecuteQuery(sql);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}

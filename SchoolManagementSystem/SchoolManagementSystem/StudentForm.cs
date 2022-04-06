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
    public partial class StudentForm : Form
    {
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private Login Lfrm { get; set; }
        public string currentId;

       

        public StudentForm()
        {
            InitializeComponent();
        }

        public StudentForm(string studentId, Login lfrm): this()
        {
            this.currentId = studentId;
            
            this.Lfrm = lfrm;
        }



        private void btnResult_Click(object sender, EventArgs e)
        {
            userControlStudentResult1.Show();
            userControlStudentInfo1.Hide();

        }

        

        

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            userControlStudentInfo1.Show();
            userControlStudentResult1.Hide();

        }

        private void btnGpa_Click(object sender, EventArgs e)
        {
            string sql = "select sname from student_info where st_id='"+this.currentId+"'";
            DataSet ds = DataAccess.ExecuteQuery(sql);
            string sid = ds.Tables[0].Rows[0][0].ToString();
            

            string sql1 = "SELECT ROUND(avg(gpa),2) as AVG_GPA FROM student_info,student_course,grade  WHERE c_result between low_number and hi_number  AND student_info.st_id=student_course.st_id  AND sname='"+sid+"'";
            DataSet ds1 = DataAccess.ExecuteQuery(sql1);
            string gpa = ds1.Tables[0].Rows[0][0].ToString();
            this.lblGPA.Text = gpa;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are want to Log Out !", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                this.Lfrm.Show();
            }
            else
            {
                MessageBox.Show("LogOut is canceled");
            }
        }
    }
}

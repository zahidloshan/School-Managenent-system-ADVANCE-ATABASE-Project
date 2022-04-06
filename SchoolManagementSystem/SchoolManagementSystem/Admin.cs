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
    public partial class Admin : Form
    {
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private Login Lfrm { get; set; }
        public string currentId;

        public Admin()
        {
            InitializeComponent();
        }

         public Admin(string adminId, Login lfrm): this()
        {
            this.currentId = adminId;
            
            this.Lfrm = lfrm;
        }

        

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            AdminProfile adp = new AdminProfile(this.currentId);
            adp.Visible = true;
            this.Visible = false;

        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            StudentAdd sadd = new StudentAdd(this.currentId,this);
            sadd.Visible = true;
            this.Visible = false;
        }

        private void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            TeacherAdd tadd = new TeacherAdd(this.currentId, this);
            tadd.Visible = true;
            this.Visible = false;
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            StudentInfomation sin = new StudentInfomation(this.currentId, this);
            sin.Visible = true;
            this.Visible = false;
        }

        private void btnTeacherInfo_Click(object sender, EventArgs e)
        {
            TeacherInformation tin = new TeacherInformation(this.currentId, this);
            tin.Visible = true;
            this.Visible = false;
        }

        private void btnStudentResult_Click(object sender, EventArgs e)
        {
            StudentResult srt = new StudentResult(this.currentId, this);
            srt.Visible = true;
            this.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

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
    public partial class StudentAdd : Form
    {
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private Admin Lfrm { get; set; }
        public string currentId;

        public StudentAdd()
        {
            InitializeComponent();
        }

         public StudentAdd(string Id, Admin lfrm): this()
        {
            this.currentId = Id;
            
            this.Lfrm = lfrm;
        }

        private void StudentAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
              this.Visible = false;
              this.Lfrm.Show();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "begin student_reg('" + this.txtStudentName.Text + "','" + this.txtFatherName.Text + "','" + this.txtMotherName.Text + "','" + this.currentId + "','" + this.txtPassingYear.Text + "'); end;";
            DataAccess.ExecuteQuery(sql);

            this.ClearAll();
        }

        private void ClearAll()
        {
            
            this.txtStudentId.Clear();
            this.txtStudentName.Text = "";
            this.txtMotherName.Clear();
            this.txtFatherName.Clear();
            this.txtPassingYear.Clear();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            string sql = @"insert into student_info
                             values ('" + this.txtStudentId.Text + "','" + this.txtStudentName.Text + "','" + this.txtFatherName.Text + "','" + this.txtMotherName.Text + "','" + this.currentId + "','" + this.txtPassingYear.Text + "')";
            DataAccess.ExecuteUpdateQuery(sql);

            this.ClearAll();

        }
    }
}

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
    public partial class TeacherAdd : Form
    {
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private Admin Lfrm { get; set; }
        public string currentId;
        public TeacherAdd()
        {
            InitializeComponent();
        }

         public TeacherAdd(string Id, Admin lfrm): this()
        {
            this.currentId = Id;
            
            this.Lfrm = lfrm;
        }

         private void TeacherAdd_FormClosed(object sender, FormClosedEventArgs e)
         {
             this.Visible = false;
             this.Lfrm.Show();
         }

         private void btnAdd_Click(object sender, EventArgs e)
         {

             string sql = "begin teacher_reg('" + this.txtTeacherName.Text + "','" + this.txtCourseName.Text + "','" + this.txtTeacherId.Text + "'); end;";
             DataAccess.ExecuteQuery(sql);

             this.ClearAll();

         }

         private void ClearAll()
         {
             
             this.txtTeacherId.Clear();
             this.txtTeacherName.Text = "";
             this.txtCourseName.Clear();
             
         }

         private void btnAdd1_Click(object sender, EventArgs e)
         {
             string sql = @"insert into teacher_info
                             values ('" + this.txtTeacherId.Text + "','" + this.txtTeacherName.Text + "','" + this.txtCourseName.Text + "')";
             DataAccess.ExecuteUpdateQuery(sql);

             this.ClearAll();
         }
    }
}

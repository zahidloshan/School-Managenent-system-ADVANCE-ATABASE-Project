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
    public partial class TeacherInformation : Form
    {
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private Admin Lfrm { get; set; }
        public string currentId;


        public TeacherInformation()
        {
            InitializeComponent();
            string sql = "select * from teacher_info";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = DataAccess.ExecuteQuery(sql);

            this.dgvStudentInfo.DataSource = this.Ds.Tables[0];

        }


        public TeacherInformation(string Id, Admin lfrm): this()
        {
            this.currentId = Id;
            
            this.Lfrm = lfrm;
        }

        private void TeacherInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.Lfrm.Show();
        }

        private void txtTeacherSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from TEACHER_INFO WHERE T_ID LIKE '%" + this.txtTeacherSearch.Text + "%'";
            this.PopulateGridView(this.Sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Teacher_Id = this.dgvStudentInfo.CurrentRow.Cells[0].Value.ToString();



            Sql = @"delete from teacher_info
                                 where t_id ='" + Teacher_Id + "'";

            DataAccess.ExecuteUpdateQuery(Sql);

            string sql = "select * from teacher_info";
            this.PopulateGridView(sql);
        }

    }
}

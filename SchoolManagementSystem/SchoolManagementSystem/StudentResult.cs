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
    public partial class StudentResult : Form
    {
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private Admin Lfrm { get; set; }
        public string currentId;

        public StudentResult()
        {
            InitializeComponent();
            string sql = "select * from student_course";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = DataAccess.ExecuteQuery(sql);

            this.dgvStudentInfo.DataSource = this.Ds.Tables[0];

        }


        public StudentResult(string Id, Admin lfrm): this()
        {
            this.currentId = Id;
            
            this.Lfrm = lfrm;
        }

        private void StudentResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.Lfrm.Show();
        }

        private void txtResultSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from student_course WHERE ST_ID LIKE '%" + this.txtResultSearch.Text + "%'";
            this.PopulateGridView(this.Sql);
        }

    }
}

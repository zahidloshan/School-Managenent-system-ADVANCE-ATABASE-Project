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
    public partial class StudentInfomation : Form
    {
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private Admin Lfrm { get; set; }
        public string currentId;

        public StudentInfomation()
        {
            InitializeComponent();
            string sql = "select * from student_info";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = DataAccess.ExecuteQuery(sql);

            this.dgvStudentInfo.DataSource = this.Ds.Tables[0];

        }


        public StudentInfomation(string Id, Admin lfrm): this()
        {
            this.currentId = Id;
            
            this.Lfrm = lfrm;
        }

        private void StudentInfomation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.Lfrm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from STUDENT_INFO WHERE ST_ID LIKE '%"+this.textBox1.Text+"%'";
            this.PopulateGridView(this.Sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Student_Id = this.dgvStudentInfo.CurrentRow.Cells[0].Value.ToString();
            


            Sql = @"delete from student_info
                                 where st_id ='" + Student_Id + "'";

            DataAccess.ExecuteUpdateQuery(Sql);

            string sql = "select * from student_info";
            this.PopulateGridView(sql);
        }




    }
}

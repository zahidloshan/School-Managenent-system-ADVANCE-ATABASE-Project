using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class UserControlStudentInfo : UserControl
    {
        
        public UserControlStudentInfo()
        {
            InitializeComponent();

            string sql = "SELECT * FROM STUDENT_INFO WHERE ST_ID='10002'";
            DataSet ds = DataAccess.ExecuteQuery(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

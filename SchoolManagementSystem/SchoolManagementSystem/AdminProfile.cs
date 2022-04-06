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
    public partial class AdminProfile : Form
    {

        
        public AdminProfile()
        {
            InitializeComponent();
        }

       
         public AdminProfile(string adminId): this()
        {
            string sql = "SELECT * FROM Teacher_Info WHERE T_ID='"+adminId+"'";
            DataSet ds = DataAccess.ExecuteQuery(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }

         private void AdminProfile_FormClosed(object sender, FormClosedEventArgs e)
         {

             Application.Exit();

         }
    }
}

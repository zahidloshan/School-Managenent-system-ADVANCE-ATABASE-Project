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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "select * from login where user_id = "+this.txtUser.Text+" and password = '"+this.txtPass.Text+"'and status='ACTIVE'";
                DataSet ds = DataAccess.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                   string sid= ds.Tables[0].Rows[0][0].ToString();
                   int nsid = Int32.Parse(sid);
                    if (nsid>=10000 && nsid<20000)
                    {
                        MessageBox.Show("Login approved for student");
                        StudentForm sf = new StudentForm(this.txtUser.Text, this);
                        sf.Visible = true;
                        this.Visible = false;

                    }
                    else if (nsid >= 20000)
                    {
                        MessageBox.Show("Login approved for Admin");
                        Admin ad = new Admin(this.txtUser.Text,this);
                        ad.Visible = true;
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Login Invalid");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Login\n" + exc.Message);
            }
              
          
        }
        }


}


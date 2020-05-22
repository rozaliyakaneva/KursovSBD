using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace carRent
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=localhost;Database=carrent;Uid=root;Pwd=root;";
        public Form1()
        {
            InitializeComponent();
            changeView(true);
        }

        private void новаАгенцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operationsAgency op = new operationsAgency();
            op.Show();
        }

        private void автомобилToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operationsAuto op = new operationsAuto();
            op.Show();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operationsClient op = new operationsClient();
            op.Show();
        }

        private void служителToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operationsUser op = new operationsUser();
            op.Show();
        }

        private void отдаванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renting op = new renting();
            op.Show();
        }

        private void приеманеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returning op = new returning();
            op.Show();
        }

        private void отдадениАвтомобилиОтСлужителToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qSlujitel op = new qSlujitel();
            op.Show();
        }

        private void отдадениАвтомобилиОтПредставителствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qFirm op = new qFirm();
            op.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("Login", mysqlCon);
                /*sqlDa.SelectCommand.Parameters.Add("_username", MySqlDbType.VarChar, 45, "Angel Kirov");
                sqlDa.SelectCommand.Parameters.Add("_password", MySqlDbType.VarChar, 45, "123");*/

                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_username", txtUsername.Text);
                sqlDa.SelectCommand.Parameters.AddWithValue("_password", txtPassword.Text);
                DataTable dtblBook = new DataTable();

                sqlDa.Fill(dtblBook);
                if(dtblBook.Rows.Count==0)
                {
                    MessageBox.Show("Login blocked by the system",
                                    "Try again with different credentials",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning
                                      );
                }
                else
                {
                    
                    Helper.curUser = dtblBook.Rows[0].Field<int>(0);//tuk zapiswame current user za da znaem s koi rabotim
                    Helper.curAgency = dtblBook.Rows[0].Field<int>(1);
                    changeView(false);
                }
            }

        }
        private void changeView(Boolean changer)
        {
            if(changer==true)
            {
                operationsToolStripMenuItem.Visible = false;
                добавянеНаToolStripMenuItem.Visible = false;
                отдаванеToolStripMenuItem.Visible = false;
                приеманеToolStripMenuItem.Visible = false;
                справкиToolStripMenuItem.Visible = false;
            }
            else
            {
                operationsToolStripMenuItem.Visible = true;
                добавянеНаToolStripMenuItem.Visible = true;
                отдаванеToolStripMenuItem.Visible = true;
                приеманеToolStripMenuItem.Visible = true;
                справкиToolStripMenuItem.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                txtUsername.Visible = false;
                txtPassword.Visible = false;
                btnLogin.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

      

       
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgroGreen
{
    public partial class Registration : System.Web.UI.Page
    {
        public string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["myDbConnectionString1"].ConnectionString;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void execution(string name, string username, string password, string emailid)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            string sql = "INSERT INTO Registration (name, username, password, emailid) VALUES "
            + " (@name, @username, @password, @emailid)";
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter[] pram = new SqlParameter[4];

                pram[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
                pram[1] = new SqlParameter("@username", SqlDbType.VarChar, 50);
                pram[2] = new SqlParameter("@password", SqlDbType.VarChar, 50);
                pram[3] = new SqlParameter("@emailid", SqlDbType.VarChar, 50);

                pram[0].Value = name;
                pram[1].Value = username;
                pram[2].Value = password;
                pram[3].Value = emailid;

                for (int i = 0; i < pram.Length; i++)
                {
                    cmd.Parameters.Add(pram[i]);
                }
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex_msg)
            {
                string msg = "Error occured while inserting";
                msg += ex_msg.Message;
                throw new Exception(msg);
            }
            finally
            {
                conn.Close();

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = ConfigurationManager.ConnectionStrings["myDbConnectionString1"].ToString();

            sds.SelectParameters.Add("name", TypeCode.String, this.TextBox1.Text);
            sds.SelectParameters.Add("username", TypeCode.String, this.TextBox2.Text);
            sds.SelectParameters.Add("password", TypeCode.String, this.TextBox3.Text);
            sds.SelectParameters.Add("emailid", TypeCode.String, this.TextBox4.Text);

            sds.SelectCommand = "SELECT * FROM [Registration] WHERE [username] = @username";

            DataView dv = (DataView)sds.Select(DataSourceSelectArguments.Empty);

            if (dv.Count != 0)
            {
                this.Label1.ForeColor = System.Drawing.Color.Red;
                this.Label1.Text = "The user already Exist!";
                return;
            }
            else
            {
                execution(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
                this.Label1.Text = "New User Profile has been created you can login now"; this.TextBox1.Text = "";
                this.TextBox2.Text = "";
                this.TextBox3.Text = "";
                this.TextBox4.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
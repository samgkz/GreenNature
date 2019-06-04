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

    public partial class _Default : Page
    {
        public string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["myDbConnectionString1"].ConnectionString;
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
           // Label1.Text = "Invalid username and password!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "Invalid username and password!";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Invalid username and password!";
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = ConfigurationManager.ConnectionStrings["myDbConnectionString1"].ToString();

            sds.SelectParameters.Add("username", TypeCode.String, this.TextBox1.Text);
            sds.SelectParameters.Add("password", TypeCode.String, this.TextBox2.Text);

            sds.SelectCommand = "SELECT * FROM [Registration] WHERE [username] = @username AND [password] = @password";

            DataView dv = (DataView)sds.Select(DataSourceSelectArguments.Empty);

            if (dv.Count == 0)
            {
                this.Label1.ForeColor = System.Drawing.Color.Red;
                this.Label1.Text = "Invalid username and password!";
                return;
            }
            else
            {
                this.Session["username"] = dv[0].Row["username"].ToString();
                Response.Redirect("About.aspx");
            }
             
        }

        protected void Button3_Click(object sender, EventArgs e)
        {Label1.Text = "Invalid username and password!";
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = ConfigurationManager.ConnectionStrings["myDbConnectionString1"].ToString();

            sds.SelectParameters.Add("username", TypeCode.String, this.TextBox1.Text);
            sds.SelectParameters.Add("password", TypeCode.String, this.TextBox2.Text);

            sds.SelectCommand = "SELECT * FROM [Registration] WHERE [username] = @username AND [password] = @password";

            DataView dv = (DataView)sds.Select(DataSourceSelectArguments.Empty);

            if (dv.Count == 0)
            {
                this.Label1.ForeColor = System.Drawing.Color.Red;
                this.Label1.Text = "Invalid username and password!";
                return;
            }
            else
            {
                this.Session["username"] = dv[0].Row["username"].ToString();
                Response.Redirect("About.aspx");
            }
             
        }

        

    }
}
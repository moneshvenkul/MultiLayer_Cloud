using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataReader rs;
    string conn = "Data Source=MOULI;Initial Catalog=cloud2;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con = new SqlConnection(conn);
        con.Open();
        string s1;
        s1 = "select * from login1 where mailid='" + TextBox1.Text + "' and pwd='" + TextBox2.Text + "'";
        SqlCommand cmd = new SqlCommand(s1, con);
        rs = cmd.ExecuteReader();
        if (rs.Read())
        {

            string id = Convert.ToString(rs.GetValue(1));
            Session["uname"] = id.ToString();
            Session["mailid"] = TextBox1.Text;
            Response.Redirect("Default.aspx");
            rs.Close();
        }
        else
        {
            MsgBox.Show("Invalid username or password");
            TextBox1.Text = "";
            TextBox2.Text = "";
            rs.Close();

        }
    }
}
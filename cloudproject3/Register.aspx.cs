using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Register : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataReader rs;
    string conn = "Data Source=MOULI;Initial Catalog=cloud2;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox2.Text == "")
        {
            MsgBox.Show("Fill All Datas");
        }
        else if (TextBox2.Text != TextBox5.Text)
        {
            MsgBox.Show("Password not matching");
        }
        else
        {
            con = new SqlConnection(conn);
            string strSQL = "Select * from login1 where mailid like '" + TextBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
            var dt = new DataTable();
            da.Fill(dt);

            if (dt != null && dt.Rows.Count == 0)
            {
                string s1 = "insert into login1 values('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox2.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(s1, con);
                cmd.ExecuteNonQuery();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                Response.Redirect("Login.aspx");
            }
            else
            {
                MsgBox.Show("Email already exists");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}
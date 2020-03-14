using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class view : System.Web.UI.Page
{
    public static int xa = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection con = new SqlConnection("Data Source=MOULI;Initial Catalog=cloud2;Integrated Security=True");
            string strSQL = "Select * from file_m where uname='" + Convert.ToString(Session["mailid"]) + "'";
            SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            dt.Fill(ds, "uname");
            con.Close();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        string f_name = Convert.ToString(GridView1.SelectedRow.Cells[1].Text);
        string dt, dt1, dt2;
        var fileStream = new FileStream(Server.MapPath("~/file1/Dropbox/cloud/" + f_name), FileMode.Open, FileAccess.Read);
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
        {
            dt = streamReader.ReadToEnd();
        }
        var fileStream1 = new FileStream(Server.MapPath("~/file1/Dropbox/cloud1/" + f_name), FileMode.Open, FileAccess.Read);
        using (var streamReader = new StreamReader(fileStream1, Encoding.UTF8))
        {
            dt1 = streamReader.ReadToEnd();
        }
        string path1 = Server.MapPath("~/temp/" + f_name);
        FileInfo file1 = new FileInfo(path1);
        if (file1.Exists)//check file exsit or not
        {
            var fileStream2 = new FileStream(Server.MapPath("~/temp/" + f_name), FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream2, Encoding.UTF8))
            {
                dt2 = streamReader.ReadToEnd();
            }

        }
        else
        {
            var fileStream2 = new FileStream(Server.MapPath("~/bin/" + f_name), FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream2, Encoding.UTF8))
            {
                dt2 = streamReader.ReadToEnd();
            }
        }
        TextBox1.Text = dt;
        TextBox4.Text = dt1;
        TextBox5.Text = dt2;
       
       
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string plain1 = CryptorEngine.Decrypt(TextBox1.Text, true);
        TextBox6.Text = plain1;
        xa = xa + 1;
        if(xa==3)
        {
            xa = 0;
            Button6.Visible = true;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string plain1 = CryptorEngine.Decrypt(TextBox4.Text, true);
        TextBox7.Text = plain1;
        xa = xa + 1;
        if (xa == 3)
        {
            xa = 0;
            Button6.Visible = true;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string plain1 = CryptorEngine.Decrypt(TextBox5.Text, true);
        TextBox8.Text = plain1;
        xa = xa + 1;
        if (xa == 3)
        {
            xa = 0;
            Button6.Visible = true;
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        string txt = TextBox6.Text + TextBox7.Text + TextBox8.Text;

        TextBox9.Text = txt;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Cipher c = new Cipher();
        string p_text = Convert.ToString(c.Decrypt(TextBox9.Text, "p@SSword"));
        TextBox10.Text = p_text;
    }
}
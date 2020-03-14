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

public partial class download : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      //  Label1.Text = Convert.ToString(Session["name"]);
        SqlConnection con = new SqlConnection("Data Source=MOULI;Initial Catalog=cloud2;Integrated Security=True");
        string strSQL = "Select * from file_m where uname='" +Convert.ToString(Session["mailid"]) + "'";
        SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);
        DataSet ds = new DataSet();
        dt.Fill(ds, "uname");
        con.Close();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string f_name = Convert.ToString(GridView1.SelectedRow.Cells[1].Text);
        string dt,dt1,dt2;
        var fileStream = new FileStream(Server.MapPath("~/file1/Dropbox/cloud/"+f_name), FileMode.Open, FileAccess.Read);
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
        
        string plain1 = CryptorEngine.Decrypt(dt, true);
        string plain2 = CryptorEngine.Decrypt(dt1, true);
        string plain3 = CryptorEngine.Decrypt(dt2, true);
        string newp=plain1+plain2+plain3;
        Cipher c = new Cipher();
        string p_text = Convert.ToString(c.Decrypt(newp, "p@SSword"));
        using (StreamWriter writer = new StreamWriter(Server.MapPath("~/temp1/") + f_name))
        {
            writer.Write(p_text);

        }
        System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
        response.ClearContent();
        response.Clear();
        response.ContentType = "text/plain";
        response.AddHeader("Content-Disposition", "attachment; filename=" + f_name + ";");
        response.TransmitFile(Server.MapPath("~/temp1/") + f_name);
        response.Flush();
        string path = Server.MapPath("~/temp1/") + f_name;
        FileInfo file = new FileInfo(path);
        if (file.Exists)//check file exsit or not
        {
            file.Delete();
           
        }
        response.End();
       
    }
}
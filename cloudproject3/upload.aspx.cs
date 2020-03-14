using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class upload : System.Web.UI.Page
{
    public static string dt;
    public static string conn = "Data Source=MOULI;Initial Catalog=cloud2;Integrated Security=True";
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader rs;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            try
            {
                
                if (FileUpload1.PostedFile.ContentType !=null && (FileUpload1.PostedFile.ContentType== "text/plain" ||
                    FileUpload1.PostedFile.ContentType.Contains("image") == true))
                
                {
                    if (FileUpload1.PostedFile.ContentLength < 102400)
                    {
                        string filename = Path.GetFileName(FileUpload1.FileName);
                        FileUpload1.SaveAs(Server.MapPath("~/temp1/") + filename);
                        var fileStream = new FileStream(Server.MapPath("~/temp1/") + filename, FileMode.Open, FileAccess.Read);
                        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                        {
                            dt = streamReader.ReadToEnd();
                        }
                        string path = Server.MapPath("~/temp1/") + filename;
                        FileInfo file = new FileInfo(path);
                        if (file.Exists)//check file exsit or not
                        {
                            file.Delete();

                        }
                        Cipher c = new Cipher();
                       string c_text= Convert.ToString( c.Encrypt(dt, "p@SSword"));
                       int a = c_text.Length;
                       int x =(int) a / 3;
                       string sub = c_text.Substring(0, x);
                       string sub1 = c_text.Substring(x, x);
                       int x1 = a-(x + x);
                       string sub2 = c_text.Substring(x+x, x1);
                       string cipherText1 = CryptorEngine.Encrypt(sub, true);
                       string cipherText2 = CryptorEngine.Encrypt(sub1, true);
                       string cipherText3 = CryptorEngine.Encrypt(sub2, true);
                       File.WriteAllText(Server.MapPath("~/file1/Dropbox/cloud/") + filename, String.Empty);
                       using (StreamWriter writer = new StreamWriter(Server.MapPath("~/file1/Dropbox/cloud/") + filename))
                       {
                           writer.Write(cipherText1);
                          
                       }
                       File.WriteAllText(Server.MapPath("~/file1/Dropbox/cloud1/") + filename, String.Empty);
                       using (StreamWriter writer = new StreamWriter(Server.MapPath("~/file1/Dropbox/cloud1/") + filename))
                       {
                           writer.Write(cipherText2);

                       }
                       File.WriteAllText(Server.MapPath("~/temp/") + filename, String.Empty);
                       using (StreamWriter writer = new StreamWriter(Server.MapPath("~/temp/") + filename))
                       {
                           writer.Write(cipherText3);

                       }
                       File.WriteAllText(Server.MapPath("~/bin/") + filename, String.Empty);
                       using (StreamWriter writer = new StreamWriter(Server.MapPath("~/bin/") + filename))
                       {
                           writer.Write(cipherText3);

                       }
                       con = new SqlConnection(conn);
                       con.Open();
                       cmd = new SqlCommand("insert into file_m values('" +Convert .ToString(Session["mailid"]) + "','" + filename + "')", con);
                       cmd.ExecuteNonQuery();
                       // FileUpload1.SaveAs(Server.MapPath("~/") + filename);
                        StatusLabel.Text = "Upload status: File uploaded!";
                    }
                    else
                        StatusLabel.Text = "Upload status: The file has to be less than 100 kb!";
                }
                else
                    StatusLabel.Text = "Upload status: Only Text files are accepted!";
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
            }
        }
    }
    

}
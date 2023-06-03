using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CvEntityProje
{
    public partial class YetenekGüncelle : System.Web.UI.Page
    {

        DBCVENTITYEntities db = new DBCVENTITYEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int ıd = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var yetenek = db.TBL_YETENEK.Find(ıd);
                TextBox1.Text = yetenek.YETENEK;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(Request.QueryString["ID"]);
            var yetenek = db.TBL_YETENEK.Find(ıd);
            yetenek.YETENEK = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");
        }
    }
}
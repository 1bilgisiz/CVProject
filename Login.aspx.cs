using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DBCVENTITYEntities db = new DBCVENTITYEntities();   

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBL_ADMIN where x.KULLANICIADI == TextBox1.Text && x.SIFRE == TextBox2.Text select x;
            if (sorgu.Any() )
            {
                Response.Redirect("İletisim.Aspx");
            }
            else
            {
                Response.Write("Hatalı kullanıcı adı yada Şifre !");
            }
        }
    }
}
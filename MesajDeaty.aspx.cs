using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class MesajDeaty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.TBL_İLETİSİM.Find(x);
            txtadsoyad.Text = mesaj.ADSOYAD;
            txtkonu.Text = mesaj.KONU;
            txtmail.Text = mesaj.MAIL;  
            txtmesaj.Text = mesaj.MESAJ;


        }
    }
}
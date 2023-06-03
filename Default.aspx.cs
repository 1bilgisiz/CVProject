using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBL_HAKKIMDA.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.TBL_HAKKIMDA.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource = db.TBL_HAKKIMDA.ToList();
            Repeater3.DataBind();

            Repeater4.DataSource = db.TBL_YETENEK.ToList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_İLETİSİM t = new TBL_İLETİSİM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox4.Text;
            t.MESAJ = TextBox3.Text;
            db.TBL_İLETİSİM.Add(t); 
            db.SaveChanges();
        }
    }
}
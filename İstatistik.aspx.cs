using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class İstatistik : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBL_YETENEK.Count().ToString();
            Label2.Text = db.TBL_İLETİSİM.Count().ToString();
            Label3.Text = db.TBL_YETENEK.Average(x=>x.DERECE).ToString();
            Label4.Text = db.TBL_YETENEK.Max(x=>x.DERECE).ToString();


        }
    }
}
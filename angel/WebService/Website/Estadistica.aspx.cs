using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Estadistica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WSDB.BaseDatosSoapClient WSS = new WSDB.BaseDatosSoapClient();
            DataSet ds = WSS.GetData();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

       

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace surveyWebAppwithTestCase
{
    public partial class DemoHTML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DemoClass obj = new DemoClass();
            Response.Write(obj.fname+ " "+obj.lname);
        }
    }
}
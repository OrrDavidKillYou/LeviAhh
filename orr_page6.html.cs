using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class orr_contact : System.Web.UI.Page
{
    public string output = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {
            string name = Request.Form["name"];
            Response.Write("Hi " + name);
        }
        else
        {
            Response.Write("Welcome");
        }
    }
}

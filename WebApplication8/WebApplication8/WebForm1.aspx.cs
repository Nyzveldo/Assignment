using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            /*int total;
            int n = int.Parse(TextBox1.Text);
            /*for(int i=1; i<=n; i += 1)
            {
                total= 
            }
            Response.Write(n);*/
            if(int.TryParse(TextBox1.Text, out int n))
            {
                n = Convert.ToInt32(TextBox1.Text);
                for (int i=1;i<=n;i++)
                {

                }
            }
        }

        
    }
}
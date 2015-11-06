using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConnectWCFByWebForms.ServiceReference1;

namespace ConnectWCFByWebForms
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.ProductServiceClient pc=new ProductServiceClient();
            var product = pc.GetProducts();
            Response.Write("<table border='1'> <tr><th>ID</th><th>Name</th><th>Unit Price</th><th>Quantity</th><th>Total</th></tr>");
            foreach (var p in product)
            {
                Response.Write("<tr><td>" + p.Id + "</td><td>" + p.Name + "</td><td>" + p.UnitPrice + "</td><td>" + p.Quantity + "</td><td>"+p.Total+"</td></tr>");
            }
            Response.Write("</table>");
        }
    }
}
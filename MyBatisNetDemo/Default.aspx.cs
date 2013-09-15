using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using EntityModel;

namespace MyBatisNetDemo
{
    public partial class Default : System.Web.UI.Page
    {
        readonly Product_BLL getproductBl = new Product_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
            }
        }

        protected void bt_Add_Click(object sender, EventArgs e)
        {
            
            getproductBl.InsertProduct(new Product()
            {
                Product_Name = "Windows  phone 7 ",
                SignDate = DateTime.Now,
                Product_Company = "Auto-Desk 7"
            });
            Response.Write("新增成功!");
        }

        protected void bt_Del_Click(object sender, EventArgs e)
        {
            int i = getproductBl.DelProduct(1);
            Response.Write("删除成功:"+i);
        }
    }
}
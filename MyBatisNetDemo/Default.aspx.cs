using System;
using System.Collections;
using BLL;

namespace MyBatisNetDemo
{
    public partial class Default : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        readonly Product_BLL getproductBl = new Product_BLL();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void bt_Add_Click(object sender, EventArgs e)
        {
            Hashtable ht=new Hashtable();
            ht.Add("Product_Name","windows phone 7");
            ht.Add("SignDate", DateTime.Now);
            ht.Add("Product_Company", "Auto-Desk 7");

            getproductBl.InsertProduct(ht);
            Response.Write("新增成功!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void bt_Del_Click(object sender, EventArgs e)
        {
            int i = getproductBl.DelProduct(1);
            Response.Write("删除成功:"+i);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void bt_Update_Click(object sender, EventArgs e)
        {
            Hashtable ht=new Hashtable();
            ht.Add("Product_Name", "0001");
            ht.Add("ProductID",1);
            getproductBl.UpdateProduct(ht);
            Response.Write("修改成功!");
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void bt_Query_Click(object sender, EventArgs e)
        {
            var dic = getproductBl.GetListInfos();
            //ArrayList arrList = getproductBl.GetListInfos() as ArrayList;
            //object obj = getproductBl.GetObjList();
        }
    }
}
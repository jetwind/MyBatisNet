using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace MyBatisNetDemo
{
    public partial class AddProduct : System.Web.UI.Page
    {
        readonly Product_BLL bll = new Product_BLL();

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
        protected void btSave_Click(object sender, EventArgs e)
        {
            Hashtable ht=new Hashtable();
            ht.Add("Product_Name",this.TextBox1.Text.Trim());
            ht.Add("Product_Company", this.TextBox2.Text.Trim());
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int j= bll.InsertBasePorduct(ht);
            sw.Stop();
            this.lblMsg.Text = "添加成功,ID:" + j + ",执行时间:" + sw.ElapsedMilliseconds + " ms!";
        }
    }
}
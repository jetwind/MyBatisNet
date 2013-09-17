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
    public partial class AddProductDetail : System.Web.UI.Page
    {
        readonly Product_BLL bll = new Product_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string par = Request.QueryString["id"];
                int id = Convert.ToInt32(par);
                Hashtable ht=new Hashtable();
                ht.Add("ProductID",id);
                var q = bll.GetProInfosById(ht);
              
                foreach (var t in q)
                {
                    Hashtable hashInfo = t as Hashtable;
                    this.lblMsg.Text = "加载编辑信息成功,加载编辑的信息为:" + BLL.JsonHelper.GetJson<Hashtable>(hashInfo);
                    this.TextBox1.Text = hashInfo["Product_Name"].ToString();
                    this.TextBox2.Text = hashInfo["Product_Company"].ToString();
                    this.TextBox3.Text = hashInfo["Product_Stand"].ToString();
                    this.TextBox4.Text = hashInfo["Product_Desc"].ToString();


                }

              
                

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btSave_Click(object sender, EventArgs e)
        {
            string par = Request.QueryString["id"];
            if (!string.IsNullOrEmpty(par))//如果参数不为空
            {
                int id = Convert.ToInt32(par);
                Hashtable ht = getSavehashtable();
                ht.Add("ProductID", id);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int j = bll.UpdateProductInfo(ht);
                sw.Stop();
                this.lblMsg.Text = "修改成功,修改后的信息为:" + BLL.JsonHelper.GetJson<Hashtable>(ht) + ",执行时间:" + sw.ElapsedMilliseconds + " ms!";
            }
            else
            {
                Hashtable ht = getSavehashtable();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int j = bll.InsertPorductDetail(ht);
                sw.Stop();
                this.lblMsg.Text = "添加成功,ID:" + j + ",执行时间:" + sw.ElapsedMilliseconds + " ms!";
            }

        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected Hashtable getSavehashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Product_Name", this.TextBox1.Text.Trim());
            ht.Add("Product_Company", this.TextBox2.Text.Trim());
            ht.Add("Product_Stand", this.TextBox3.Text.Trim());
            ht.Add("Product_Desc", this.TextBox4.Text.Trim());
            return ht;
        }
    }
}
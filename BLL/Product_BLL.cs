using System.Collections;
using DAL;
using EntityModel;

namespace BLL
{
    public class Product_BLL
    {
        /// <summary>
        /// 实例化产品DAL
        /// </summary>
        readonly  DAL.ProductDAL dal=new ProductDAL();

        /// <summary>
        /// 新增产品信息
        /// </summary>
        /// <param name="productInfo">产品信息</param>
        public void InsertProduct(Product productInfo)
        {
            if (productInfo != null)
            {
                dal.InsertPorduct(productInfo);
            }
        }

        public IDictionary getInfos()
        {
            return dal.GetInfos();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public IList GetListInfos()
        {
            return dal.GetListInfos();
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="productId">产品ID</param>
        /// <returns></returns>
        public int DelProduct(int productId)
        {
            return dal.DelProductInfo(productId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ht"></param>
        public void UpdateProduct(Hashtable ht)
        {
            dal.UpdateProduct(ht);
        }

        public object GetObjList()
        {
            return dal.GetObjList();
        }

    }
}

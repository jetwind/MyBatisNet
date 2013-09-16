using System;
using System.Collections;
using System.Data;
using System.Linq;
using EntityModel;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;


namespace DAL
{
    public class ProductDAL
    {


        

        //private readonly ISqlMapper _getSqlManager;

        //public  static SqlMapper  GetSqlMapper=null;

        //public ProductDAL()
        //{
        //    //DomSqlMapBuilder getdomBuilder = new DomSqlMapBuilder();
        //    //if (getdomBuilder != null)
        //    //{
        //    //    ProductDAL._getSqlMapper = getdomBuilder.Configure() as SqlMapper;

        //    //}
        //    _getSqlManager = Mapper.Instance();
        //}

        /// <summary>
        /// 新增产品
        /// </summary>
        /// <param name="productInfoProduct"></param>
        public void InsertPorduct(Product productInfoProduct)
        {
            //Mapper.Instance().
            //ISqlMapSession iSqlMapSession = new SqlMapSession();
            Mapper.Instance().Insert("insertProduct", productInfoProduct);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ht"></param>
        public void UpdateProduct(Hashtable ht)
        {
            Mapper.Instance().Update("UpdateProduct", ht);
        }


        /// <summary>
        /// 查询 返回DictoryInfo
        /// </summary>
        /// <returns></returns>
        public IDictionary GetInfos()
        {
            return Mapper.Instance().QueryForMap("SelectAllProduct", new object(),"ProductID");
        }

        /// <summary>
        /// 查询 返回arrayList
        /// </summary>
        /// <returns></returns>
        public IList GetListInfos()
        {
            return Mapper.Instance().QueryForList("SelectAllProduct", new object());

 
        }

        public object GetObjList()
        {
            return Mapper.Instance().QueryForObject<object>("SelectAllProduct", new object());
        }


        /// <summary>
        /// 删除产品信息
        /// </summary>
        /// <param name="productId"></param>
        public int DelProductInfo(int productId)
        {
            return 0;
        }


    }
}

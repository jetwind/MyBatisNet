using System;
using System.Collections;
using IBatisNet.DataMapper;


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
        public void InsertPorduct(Hashtable hs)
        {
            //Mapper.Instance().
            //ISqlMapSession iSqlMapSession = new SqlMapSession();
             Mapper.Instance().Insert("insertProduct", hs);
        }

        /// <summary>
        /// 新增产品
        /// </summary>
        /// <param name="productInfoProduct"></param>
        public int InsertBasePorduct(Hashtable hs)
        {
            return InsertReturnIden("insertBaseProduct",hs);
        }

        /// <summary>
        /// 新增产品
        /// </summary>
        /// <param name="productInfoProduct"></param>
        public int InsertPorductDetail(Hashtable hs)
        {
            return InsertReturnIden("insertProduct", hs);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="statemment"></param>
        /// <param name="hs"></param>
        /// <returns></returns>
        public int InsertReturnIden(string statemment,Hashtable hs)
        {
            object obj = Mapper.Instance().Insert(statemment, hs);
            if (obj != null)
            {
                return (int)obj;
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="statemment"></param>
        /// <param name="hs"></param>
        /// <returns></returns>
        public int UpdateReturnIden(string statemment, Hashtable hs)
        {
            object obj = Mapper.Instance().Update(statemment, hs);
            if (obj != null)
            {
                return (int)obj;
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ht"></param>
        public int UpdateProductInfo(Hashtable ht)
        {
            return UpdateReturnIden("UpdateProduct", ht); 
            //Mapper.Instance().Update("UpdateProduct", ht);
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
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public IList GetProInfosById(Hashtable hs)
        {
            return Mapper.Instance().QueryForList("sp_GetProductInfos", hs);
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

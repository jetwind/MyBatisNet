using System;
using EntityModel;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;

namespace DAL
{
    public class ProductDAL
    {


        private ISqlMapper _getSqlManager;

        public  static SqlMapper  _getSqlMapper=null;

        public ProductDAL()
        {
            DomSqlMapBuilder getdomBuilder = new DomSqlMapBuilder();
            if (getdomBuilder != null)
            {
                ProductDAL._getSqlMapper = getdomBuilder.Configure() as SqlMapper;

            }
            _getSqlManager = Mapper.Instance();
        }

        /// <summary>
        /// 新增产品
        /// </summary>
        /// <param name="productInfoProduct"></param>
        public void InsertPorduct(Product productInfoProduct)
        {
            if (_getSqlManager != null)
            {
                _getSqlManager.Insert("insertProduct", productInfoProduct);
            }
        }

        /// <summary>
        /// 删除产品信息
        /// </summary>
        /// <param name="productId"></param>
        public int DelProductInfo(int productId)
        {
            if (_getSqlManager != null)
            {
                _getSqlManager.BeginTransaction();
                try
                {
                    int getCounter = Mapper.Instance().Delete("DeleteProduct", productId);
                    _getSqlManager.CommitTransaction();
                    return getCounter;
                }
                catch
                {
                    _getSqlManager.RollBackTransaction();
                    throw;
                }
            }
            return 0;
        }


    }
}

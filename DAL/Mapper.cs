using IBatisNet.Common.Utilities;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;

namespace DAL
{
    //public class MapperService
    //{
    //    /// <summary>
    //    /// sqlmapper Interface
    //    /// </summary>
    //    private static volatile ISqlMapper _mapper = null;

    //    /// <summary>
    //    /// 初始化配置
    //    /// </summary>
    //    /// <param name="obj"></param>
    //    protected static void Configure(object obj)
    //    {
    //        _mapper = null;
    //    }

    //    /// <summary>
    //    /// 初始化Mapper
    //    /// </summary>
    //    protected static void InitMapper()
    //    {
    //        ConfigureHandler handler = new ConfigureHandler(Configure);
    //        DomSqlMapBuilder builder=new DomSqlMapBuilder();
    //        _mapper = builder.ConfigureAndWatch(handler);
    //    }

    //    /// <summary>
    //    /// 返回单例ISqlMapper
    //    /// </summary>
    //    /// <returns></returns>
    //    public static ISqlMapper Instance()
    //    {
    //        if (_mapper == null)
    //        {
    //            lock (typeof(SqlMapper))
    //            {
    //                if (_mapper == null)
    //                {
    //                    InitMapper();
    //                }
    //            }
    //        }
    //        return _mapper;
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <returns></returns>
    //    public static ISqlMapper Get()
    //    {
    //        return Instance();
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public static ISqlMapper GetMapper
    //    {
    //        get
    //        {
    //            if (_mapper == null)
    //            {
    //                lock (typeof(ISqlMapper))
    //                {
    //                    if (_mapper == null)
    //                    {
    //                        ConfigureHandler handler=new ConfigureHandler(Configure);
    //                        DomSqlMapBuilder builder=new DomSqlMapBuilder();
    //                        _mapper = Mapper.Instance();
    //                    }
    //                }
    //            }
    //            return Mapper.Instance();

    //        }
    //    }



    //}
}

/*******************************************************************************
 * Copyright © 2016 微猴科技 版权所有
 * Author: 微猴科技
 * Description: 慧猪帮传感器
 * Website：http://www.huizhubang.com
*********************************************************************************/
using log4net;
using System;
using System.IO;
using System.Web;

namespace NFine.Code
{
    public class LogFactory
    {
        static LogFactory()
        {
            FileInfo configFile = new FileInfo(HttpContext.Current.Server.MapPath("/Configs/log4net.config"));
            log4net.Config.XmlConfigurator.Configure(configFile);
        }
        public static Log GetLogger(Type type)
        {
            return new Log(LogManager.GetLogger(type));
        }
        public static Log GetLogger(string str)
        {
            return new Log(LogManager.GetLogger(str));
        }
    }
}

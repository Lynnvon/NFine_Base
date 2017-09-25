/*******************************************************************************
 * Copyright © 2016 微猴科技 版权所有
 * Author: 微猴科技
 * Description: 慧猪帮传感器
 * Website：http://www.huizhubang.com
*********************************************************************************/
using System;

namespace NFine.Code
{
    public class OperatorModel
    {
        public string UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string CompanyId { get; set; }
        public string DepartmentId { get; set; }
        public string RoleId { get; set; }
        public string LoginIPAddress { get; set; }
        public string LoginIPAddressName { get; set; }
        public string LoginToken { get; set; }
        public DateTime LoginTime { get; set; }
        public bool IsSystem { get; set; }
    }
}

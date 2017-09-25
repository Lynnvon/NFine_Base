/*******************************************************************************
 * Copyright © 2016 微猴科技 版权所有
 * Author: 微猴科技
 * Description: 慧猪帮传感器
 * Website：http://www.huizhubang.com
*********************************************************************************/

namespace NFine.Code
{
    public class TreeGridModel
    {
        public string id { get; set; }
        public string parentId { get; set; }
        public string text { get; set; }
        public bool isLeaf { get; set; }
        public bool expanded { get; set; }
        public bool loaded { get; set; }
        public string entityJson { get; set; }
    }
}

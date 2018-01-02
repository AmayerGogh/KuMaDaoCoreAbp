using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Dto
{
  
    public class BsTableRequestModel
    {
        public string order { get; set; }
        /// <summary>
        /// 从第几个开始
        /// </summary>
        public int offset { get; set; }
        /// <summary>
        /// 多少个
        /// </summary>
        public int limit { get; set; }
        public string search { get; set; }

        public Dictionary<string,string> searches { get; set; }
    }

    public class BsTableResponseModel<T>
    {
        /// <summary>
        /// 一定要一样
        /// </summary>
        public List<T> rows { get; set; }
        public int total { get; set; }
    }
}

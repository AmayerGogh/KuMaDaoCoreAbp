using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Common
{
   public  class CommonAppService : KuMaDaoCoreAbpAppServiceBase, ICommonAppService
    {



        /// <summary>
        /// 通过Id获取文章信息进行编辑或修改 
        /// </summary>
        public string  GetUeditor()
        {
            return "test";
        }
    }
}

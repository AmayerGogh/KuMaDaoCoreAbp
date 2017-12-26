using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Types
{
   public  class BaseDataType:Entity<long>
    {

        public string Name { get; set; }
        public int  Status { get; set; }
        public string Mark { get; set; }
    }



   public enum EnumBaseDataType
    {

    }
}

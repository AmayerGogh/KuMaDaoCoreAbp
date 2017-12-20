using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Type
{
   public  class BaseData:Entity<long>
    {
        public  string Name { get; set; }
        public long TypeId { get; set; }
        public string Description { get; set; }
        public  int Status { get; set; }
        public string Param1 { get; set; }        
        public string Param2 { get; set; }
        public string Param3 { get; set; }
    }
}

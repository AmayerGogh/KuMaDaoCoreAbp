using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Cache
{
    /// <summary>
    /// redis模拟
    /// </summary>
    public class RedisSimulation
    {      
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime DeadlineTime { get; set; }
    }
}

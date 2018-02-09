using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Common
{
    /// <summary>
    /// 
    /// </summary>
    public interface  ICommonAppService: IApplicationService
    {
        string GetUeditor();
    }
}

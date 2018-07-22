using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using KuMaDaoCoreAbp.Categories;

namespace KuMaDaoCoreAbp.Categories.DomainServices
{
    public interface ICategoryManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        /// </summary>
        void InitCategory();

    }
}

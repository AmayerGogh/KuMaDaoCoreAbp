using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using KuMaDaoCoreAbp.Categories;

namespace KuMaDaoCoreAbp.Categories.DomainServices
{
    /// <summary>
    /// Category领域层的业务管理
    /// </summary>
    public class CategoryManager :  ICategoryManager
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        private readonly IRepository<Category, long> _categoryRepository;
        /// <summary>
        /// Category的构造方法
        /// </summary>
        public CategoryManager(IRepository<Category, long> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        //TODO:编写领域业务代码
        /// <summary>
        ///     初始化
        /// </summary>
        public void InitCategory()
        {
            throw new NotImplementedException();
        }

    }

}

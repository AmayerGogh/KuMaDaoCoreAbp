using Abp.MultiTenancy;
using KuMaDaoCoreAbp.Authorization.Users;

namespace KuMaDaoCoreAbp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}

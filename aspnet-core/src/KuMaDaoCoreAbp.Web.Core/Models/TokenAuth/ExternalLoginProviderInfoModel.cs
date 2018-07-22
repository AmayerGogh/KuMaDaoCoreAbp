using Abp.AutoMapper;
using KuMaDaoCoreAbp.Authentication.External;

namespace KuMaDaoCoreAbp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}

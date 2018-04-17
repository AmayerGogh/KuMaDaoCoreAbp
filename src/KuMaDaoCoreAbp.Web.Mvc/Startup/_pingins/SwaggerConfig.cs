using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Web.Startup._pingins
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public partial class HiddenApiAttribute : Attribute { }
    public class HiddenApiFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            foreach (ApiDescription apiDescription in context.ApiDescriptionsGroups.Items.SelectMany(e => e.Items))
            {
                if (apiDescription.ControllerAttributes().OfType<HiddenApiAttribute>().Count() == 0
                    && apiDescription.ActionAttributes().OfType<HiddenApiAttribute>().Count() == 0) continue;

                var key = "/" + apiDescription.RelativePath.TrimEnd('/');
                if (!key.Contains("/test/") && swaggerDoc.Paths.ContainsKey(key))
                    swaggerDoc.Paths.Remove(key);
            }
        }
    }
}

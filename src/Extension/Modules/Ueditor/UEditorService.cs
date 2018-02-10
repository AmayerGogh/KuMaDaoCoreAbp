using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Amayer.Modules.Ueditor
{
    public class UEditorService
    {
        private UEditorActionCollection actionList;

        public UEditorService(IHostingEnvironment env, UEditorActionCollection actions)
        {
            Config.WebRootPath = env.WebRootPath;
            actionList = actions;
        }

        public void DoAction(HttpContext context)
        {
            var action = context.Request.Query["action"];
            if (actionList.ContainsKey(action))
                actionList[action].Invoke(context);
            else
                new NotSupportedHandler(context).Process();
        }
    }

    public static class UEditorServiceExtension
    {
        public static UEditorActionCollection AddUEditorService(
            this IServiceCollection services,
            string configFile = "config.json",
            bool isCache = false)
        {
            Config.ConfigFile = configFile;
            Config.noCache = !isCache;

            var actions = new UEditorActionCollection();
            services.AddSingleton(actions);
            services.AddSingleton<UEditorService>();
            return actions;
        }
    }


    public class Ueditor
    {
        private string type;
        public Ueditor(HttpContext context , string type)
        {
            this.type = type;
            switch (type)
            {
                case "config":ConfigAction(context);
                    break;
                case "uploadimage":
                    ConfigAction(context);
                    break;
                case "uploadscrawl":
                    ConfigAction(context);
                    break;
                case "uploadvideo":
                    ConfigAction(context);
                    break;
                case "uploadfile":
                    ConfigAction(context);
                    break;
                case "listimage":
                    ConfigAction(context);
                    break;
                case "listfile":
                    ConfigAction(context);
                    break;
                case "catchimage":
                    CatchImageAction(context);
                    break;
                default:
                    break;
            }

        }
        private void ConfigAction(HttpContext context)
        {
            new ConfigHandler(context).Process();
        }
        private void UploadImageAction(HttpContext context)
        {
            new UploadHandler(context, new UploadConfig()
            {
                AllowExtensions = Config.GetStringList("imageAllowFiles"),
                PathFormat = Config.GetString("imagePathFormat"),
                SizeLimit = Config.GetInt("imageMaxSize"),
                UploadFieldName = Config.GetString("imageFieldName")
            }).Process();
        }

        private void UploadScrawlAction(HttpContext context)
        {
            new UploadHandler(context, new UploadConfig()
            {
                AllowExtensions = new string[] { ".png" },
                PathFormat = Config.GetString("scrawlPathFormat"),
                SizeLimit = Config.GetInt("scrawlMaxSize"),
                UploadFieldName = Config.GetString("scrawlFieldName"),
                Base64 = true,
                Base64Filename = "scrawl.png"
            }).Process();
        }

        private void UploadVideoAction(HttpContext context)
        {
            new UploadHandler(context, new UploadConfig()
            {
                AllowExtensions = Config.GetStringList("videoAllowFiles"),
                PathFormat = Config.GetString("videoPathFormat"),
                SizeLimit = Config.GetInt("videoMaxSize"),
                UploadFieldName = Config.GetString("videoFieldName")
            }).Process();
        }

        private void UploadFileAction(HttpContext context)
        {
            new UploadHandler(context, new UploadConfig()
            {
                AllowExtensions = Config.GetStringList("fileAllowFiles"),
                PathFormat = Config.GetString("filePathFormat"),
                SizeLimit = Config.GetInt("fileMaxSize"),
                UploadFieldName = Config.GetString("fileFieldName")
            }).Process();
        }

        private void ListImageAction(HttpContext context)
        {
            new ListFileManager(
                    context,
                    Config.GetString("imageManagerListPath"),
                    Config.GetStringList("imageManagerAllowFiles"))
                .Process();
        }

        private void ListFileAction(HttpContext context)
        {
            new ListFileManager(
                    context,
                    Config.GetString("fileManagerListPath"),
                    Config.GetStringList("fileManagerAllowFiles"))
                .Process();
        }
        private void CatchImageAction(HttpContext context)
        {
            new CrawlerHandler(context).Process();
        }
    }
}

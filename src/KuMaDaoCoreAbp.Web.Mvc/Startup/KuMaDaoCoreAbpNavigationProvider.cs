using Abp.Application.Navigation;
using Abp.Localization;
using KuMaDaoCoreAbp.Authorization;

namespace KuMaDaoCoreAbp.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class KuMaDaoCoreAbpNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(new MenuItemDefinition(PageNames.Home, L("HomePage"), url: "", icon: "home", requiresAuthentication: true))
                .AddItem(Demonav())
                .AddItem(Wechat())
                .AddItem(Alimm())
                .AddItem(Setting());
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, KuMaDaoCoreAbpConsts.LocalizationSourceName);
        }
        private static MenuItemDefinition Setting()
        {
            return new MenuItemDefinition("管理", L("guanli"), url: "", icon: "menu", requiresAuthentication: true)
                         .AddItem(new MenuItemDefinition(PageNames.Tenants, L("Tenants"), url: "Tenants", requiredPermissionName: PermissionNames.Pages_Tenants))
                         .AddItem(new MenuItemDefinition(PageNames.Users, L("Users"), url: "Users", requiredPermissionName: PermissionNames.Pages_Users))
                         .AddItem(new MenuItemDefinition(PageNames.Roles, L("Roles"), url: "Roles", requiredPermissionName: PermissionNames.Pages_Roles))
                         .AddItem(new MenuItemDefinition(PageNames.About, L("About"), url: "About"))
                         .AddItem(new MenuItemDefinition("常用数据", new FixedLocalizableString("ASP.NET Boilerplate"))
                          .AddItem(new MenuItemDefinition("json数据", new FixedLocalizableString("Home"), url: "https://aspnetboilerplate.com?ref=abptmpl"))


                         );
        }


        private static MenuItemDefinition Demonav()
        {
            return new MenuItemDefinition("内容", L("MultiLevelMenu"), icon: "menu")
                .AddItem(new MenuItemDefinition("分类", L("Article"), url: "Article"))
                .AddItem(new MenuItemDefinition(PageNames.Article, L("Article"), url: "Article"))
                .AddItem(new MenuItemDefinition("媒体库", new FixedLocalizableString("Templates"), url: "https://aspnetboilerplate.com/Templates?ref=abptmpl"))
               ;
        }

        private static MenuItemDefinition Wechat()
        {
            return new MenuItemDefinition("微信", L("MultiLevelMenu"), icon: "menu")
                .AddItem(new MenuItemDefinition("菜单栏", L("Article"), url: "Article"))
                .AddItem(new MenuItemDefinition("用户", L("Article"), url: "Article"))
                .AddItem(new MenuItemDefinition("消息", new FixedLocalizableString("ASP.NET Boilerplate"))
                .AddItem(new MenuItemDefinition("json数据", new FixedLocalizableString("Home"), url: "https://aspnetboilerplate.com?ref=abptmpl"))
                .AddItem(new MenuItemDefinition("媒体库", new FixedLocalizableString("Templates"), url: "https://aspnetboilerplate.com/Templates?ref=abptmpl"))
                );
        }
        private static MenuItemDefinition Alimm()
        {
            return new MenuItemDefinition("淘宝客", L("MultiLevelMenu"), icon: "menu")
                .AddItem(new MenuItemDefinition("菜单栏", L("Article"), url: "Article"))
                .AddItem(new MenuItemDefinition("用户", L("Article"), url: "Article"))
                .AddItem(new MenuItemDefinition("消息", new FixedLocalizableString("ASP.NET Boilerplate"))
                .AddItem(new MenuItemDefinition("json数据", new FixedLocalizableString("Home"), url: "https://aspnetboilerplate.com?ref=abptmpl"))
                .AddItem(new MenuItemDefinition("媒体库", new FixedLocalizableString("Templates"), url: "https://aspnetboilerplate.com/Templates?ref=abptmpl"))
                );
        }
    }
}

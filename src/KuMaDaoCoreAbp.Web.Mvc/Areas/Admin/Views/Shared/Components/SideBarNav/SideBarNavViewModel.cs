using Abp.Application.Navigation;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Views.Shared.Components.SideBarNav
{
    public class SideBarNavViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}

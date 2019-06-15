namespace KuMaDaoCoreAbp.Configuration.Ui
{
    /// <summary></summary>
    public class UiThemeInfo
    {
        /// <summary></summary>
        public string Name { get; }
        /// <summary></summary>
        public string CssClass { get; }
        /// <summary></summary>
        public UiThemeInfo(string name, string cssClass)
        {
            Name = name;
            CssClass = cssClass;
        }
    }
}

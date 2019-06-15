namespace KuMaDaoCoreAbp.Sessions.Dto
{
    /// <summary></summary>
    public class GetCurrentLoginInformationsOutput
    {
        /// <summary></summary>
        public ApplicationInfoDto Application { get; set; }
        /// <summary></summary>
        public UserLoginInfoDto User { get; set; }
        /// <summary></summary>
        public TenantLoginInfoDto Tenant { get; set; }
    }
}

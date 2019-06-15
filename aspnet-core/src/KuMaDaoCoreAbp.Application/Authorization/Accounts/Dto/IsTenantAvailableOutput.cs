namespace KuMaDaoCoreAbp.Authorization.Accounts.Dto
{
    /// <summary></summary>
    public class IsTenantAvailableOutput
    {
        /// <summary></summary>
        public TenantAvailabilityState State { get; set; }
        /// <summary></summary>
        public int? TenantId { get; set; }
        /// <summary></summary>
        public IsTenantAvailableOutput()
        {
        }
        /// <summary></summary>
        public IsTenantAvailableOutput(TenantAvailabilityState state, int? tenantId = null)
        {
            State = state;
            TenantId = tenantId;
        }
    }
}

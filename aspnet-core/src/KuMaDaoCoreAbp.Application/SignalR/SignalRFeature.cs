namespace KuMaDaoCoreAbp.SignalR
{
    /// <summary></summary>
    public static class SignalRFeature
    {
        /// <summary></summary>
        public static bool IsAvailable
        {
            get
            {
#if FEATURE_SIGNALR
                return true;
#else
                return false;
#endif
            }
        }
    }
}

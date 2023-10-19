namespace XyloCode.ThirdPartyServices.RussianPost.Enums
{
    public enum TransportType : byte
    {
        /// <summary>
        /// Наземный.
        /// </summary>
        SURFACE = 1,

        /// <summary>
        /// Авиа
        /// </summary>
        AVIA,

        /// <summary>
        /// Комбинированный.
        /// </summary>
        COMBINED,

        /// <summary>
        /// Системой ускоренной почты.
        /// </summary>
        EXPRESS,

        /// <summary>
        /// Используется для отправлений "EMS Оптимальное".
        /// </summary>
        STANDARD,
    }
}

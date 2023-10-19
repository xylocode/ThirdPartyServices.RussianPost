namespace XyloCode.ThirdPartyServices.RussianPost.Enums
{
    public enum AddressType : byte
    {
        /// <summary>
        /// Стандартный (улица, дом, квартира)
        /// </summary>
        DEFAULT = 0,

        /// <summary>
        /// Абонентский ящик
        /// </summary>
        PO_BOX,

        /// <summary>
        /// До востребования
        /// </summary>
        DEMAND,

        /// <summary>
        /// Для военных частей
        /// </summary>
        UNIT,
    }
}

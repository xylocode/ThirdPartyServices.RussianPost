namespace XyloCode.ThirdPartyServices.RussianPost.CleanAddress
{
    public enum QualityCode : byte
    {
        /// <summary>
        /// Пригоден для почтовой рассылки
        /// </summary>
        GOOD = 1,

        /// <summary>
        /// До востребования
        /// </summary>
        ON_DEMAND,

        /// <summary>
        /// Абонентский ящик
        /// </summary>
        POSTAL_BOX,

        /// <summary>
        /// Не определен регион
        /// </summary>
        UNDEF_01,

        /// <summary>
        /// Не определен город или населенный пункт
        /// </summary>
        UNDEF_02,

        /// <summary>
        /// Не определена улица
        /// </summary>
        UNDEF_03,

        /// <summary>
        /// Не определен номер дома
        /// </summary>
        UNDEF_04,

        /// <summary>
        /// Не определена квартира/офис
        /// </summary>
        UNDEF_05,

        /// <summary>
        /// Не определен
        /// </summary>
        UNDEF_06,

        /// <summary>
        /// Иностранный адрес
        /// </summary>
        UNDEF_07,
    }
}

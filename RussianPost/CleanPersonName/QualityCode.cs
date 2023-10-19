namespace XyloCode.ThirdPartyServices.RussianPost.CleanPersonName
{
    public enum QualityCode : byte
    {
        /// <summary>
        /// Подтверждено контролером
        /// </summary>
        CONFIRMED_MANUALLY = 1,

        /// <summary>
        /// Правильное значение
        /// </summary>
        EDITED,

        /// <summary>
        /// Сомнительное значение
        /// </summary>
        NOT_SURE,
    }
}
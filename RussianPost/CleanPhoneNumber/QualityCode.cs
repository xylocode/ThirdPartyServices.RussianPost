namespace XyloCode.ThirdPartyServices.RussianPost.CleanPhoneNumber
{
    public enum QualityCode : byte
    {
        /// <summary>
        /// Подтверждено контролером
        /// </summary>
        CONFIRMED_MANUALLY = 1,

        /// <summary>
        /// Корректный телефонный номер
        /// </summary>
        GOOD,

        /// <summary>
        /// Изменен код телефонного номера
        /// </summary>
        GOOD_REPLACED_CODE,

        /// <summary>
        /// Изменен номер телефона
        /// </summary>
        GOOD_REPLACED_NUMBER,

        /// <summary>
        /// Изменен код и номер телефона
        /// </summary>
        GOOD_REPLACED_CODE_NUMBER,

        /// <summary>
        /// Конфликт по городу
        /// </summary>
        GOOD_CITY_CONFLICT,

        /// <summary>
        /// Конфликт по региону
        /// </summary>
        GOOD_REGION_CONFLICT,

        /// <summary>
        /// Иностранный телефонный номер
        /// </summary>
        FOREIGN,

        /// <summary>
        /// Неоднозначный код телефонного номера
        /// </summary>
        CODE_AMBI,

        /// <summary>
        /// Пустой телефонный номер
        /// </summary>
        EMPTY,

        /// <summary>
        /// Телефонный номер содержит некорректные символы
        /// </summary>
        GARBAGE,

        /// <summary>
        /// Восстановлен город в телефонном номере
        /// </summary>
        GOOD_CITY,

        /// <summary>
        /// Запись содержит более одного телефона
        /// </summary>
        GOOD_EXTRA_PHONE,

        /// <summary>
        /// Телефон не может быть распознан
        /// </summary>
        UNDEF,

        /// <summary>
        /// Телефон не может быть распознан
        /// </summary>
        INCORRECT_DATA,
    }
}
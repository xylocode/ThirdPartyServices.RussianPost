namespace XyloCode.ThirdPartyServices.RussianPost.Enums
{
    public enum MailType : byte
    {
        /// <summary>
        /// Посылка "нестандартная"
        /// </summary>
        POSTAL_PARCEL = 1,

        /// <summary>
        /// Посылка "онлайн"
        /// </summary>
        ONLINE_PARCEL,

        /// <summary>
        /// Курьер "онлайн"
        /// </summary>
        ONLINE_COURIER,

        /// <summary>
        /// Отправление EMS
        /// </summary>
        EMS,

        /// <summary>
        /// EMS оптимальное
        /// </summary>
        EMS_OPTIMAL,

        /// <summary>
        /// EMS РТ
        /// </summary>
        EMS_RT,

        /// <summary>
        /// EMS тендер
        /// </summary>
        EMS_TENDER,

        /// <summary>
        /// Письмо
        /// </summary>
        LETTER,

        /// <summary>
        /// Письмо 1-го класса
        /// </summary>
        LETTER_CLASS_1,

        /// <summary>
        /// Бандероль
        /// </summary>
        BANDEROL,

        /// <summary>
        /// Бизнес курьер
        /// </summary>
        BUSINESS_COURIER,

        /// <summary>
        /// Бизнес курьер экпресс
        /// </summary>
        BUSINESS_COURIER_ES,

        /// <summary>
        /// Посылка 1-го класса
        /// </summary>
        PARCEL_CLASS_1,

        //Бандероль 1-го класса
        BANDEROL_CLASS_1,


        /// <summary>
        /// ВГПО 1-го класса
        /// </summary>
        VGPO_CLASS_1,


        /// <summary>
        /// Мелкий пакет
        /// </summary>
        SMALL_PACKET,


        /// <summary>
        /// Легкий возврат
        /// </summary>
        EASY_RETURN,


        /// <summary>
        /// Отправление ВСД
        /// </summary>
        VSD,


        /// <summary>
        /// ЕКОМ
        /// </summary>
        ECOM,


        /// <summary>
        /// ЕКОМ Маркетплейс
        /// </summary>
        ECOM_MARKETPLACE,


        /// <summary>
        /// Доставка день в день
        /// </summary>
        HYPER_CARGO,

        /// <summary>
        /// Комбинированное
        /// </summary>
        COMBINED,
    }
}

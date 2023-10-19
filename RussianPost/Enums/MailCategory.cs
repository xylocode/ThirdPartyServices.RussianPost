namespace XyloCode.ThirdPartyServices.RussianPost.Enums
{
    public enum MailCategory : byte
    {
        /// <summary>
        /// Простое
        /// </summary>
        SIMPLE=1,

        /// <summary>
        /// Заказное
        /// </summary>
        ORDERED,
        
        /// <summary>
        /// Обыкновенное
        /// </summary>
        ORDINARY,
        
        /// <summary>
        /// С объявленной ценностью
        /// </summary>
        WITH_DECLARED_VALUE,
        
        /// <summary>
        /// С объявленной ценностью и наложенным платежом
        /// </summary>
        WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,
        
        /// <summary>
        /// С объявленной ценностью и обязательным платежом
        /// </summary>
        WITH_DECLARED_VALUE_AND_COMPULSORY_PAYMENT,
        
        /// <summary>
        /// С обязательным платежом
        /// </summary>
        WITH_COMPULSORY_PAYMENT,
        
        /// <summary>
        /// Комбинированное обыкновенное
        /// </summary>
        COMBINED_ORDINARY,
        
        /// <summary>
        /// Комбинированное с объявленной ценностью
        /// </summary>
        COMBINED_WITH_DECLARED_VALUE,
        
        /// <summary>
        /// Комбинированное с объявленной ценностью и наложенным платежом
        /// </summary>
        COMBINED_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,
    }
}

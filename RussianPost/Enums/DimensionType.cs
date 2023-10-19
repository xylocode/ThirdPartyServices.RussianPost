using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.RussianPost.Enums
{
    public enum DimensionType : byte
    {
        /// <summary>
        /// до 260х170х80 мм
        /// </summary>
        S = 1,

        /// <summary>
        /// до 300х200х150 мм
        /// </summary>
        M,

        /// <summary>
        /// до 400х270х180 мм
        /// </summary>
        L,

        /// <summary>
        /// 530х260х220 мм
        /// </summary>
        XL,

        /// <summary>
        /// Негабарит (сумма сторон не более 1400 мм, сторона не более 600 мм)
        /// </summary>
        OVERSIZED,
    }
}

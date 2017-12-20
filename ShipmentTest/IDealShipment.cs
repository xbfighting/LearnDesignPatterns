using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTest
{
    public interface IDealShipment
    {
        /// <summary>
        /// 运单生成
        /// </summary>
        /// <param name="operate">操作类</param>
        /// <returns></returns>
        void ShipmentGen(IOpeartor operate);

        /// <summary>
        /// 绑定运单
        /// </summary>
        /// <param name="operate">操作类</param>
        /// <returns></returns>
        void BindShipment(IOpeartor operate);
    }
}

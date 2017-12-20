using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTest
{
    public class FirstDealShipment : IDealShipment
    {
        /// <summary>
        /// 运单生成
        /// </summary>
        /// <param name="operate">操作类</param>
        /// <returns></returns>
        public void ShipmentGen(IOpeartor operate)
        {
            operate.Op1("ShipmentGen");
            operate.Op2("ShipmentGen");
            operate.Op3("ShipmentGen");
            operate.Default("ShipmentGen");
        }

        /// <summary>
        /// 绑定运单
        /// </summary>
        /// <param name="operate">操作类</param>
        /// <returns></returns>
        public void BindShipment(IOpeartor operate)
        {
            operate.Op2("BindShipment");
            operate.Op3("BindShipment");
        }
    }
}

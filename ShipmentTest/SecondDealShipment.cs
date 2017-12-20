using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTest
{
    public class SecondDealShipment : IDealShipment
    {
        /// <summary>
        /// 运单生成
        /// </summary>
        /// <param name="operate">操作类</param>
        /// <returns></returns>
        public void ShipmentGen(IOpeartor operate)
        {
            operate.Default("ShipmentGen");
            operate.Op3("ShipmentGen");
            operate.Op2("ShipmentGen");
            operate.Op1("ShipmentGen");
        }

        /// <summary>
        /// 绑定运单
        /// </summary>
        /// <param name="operate">操作类</param>
        /// <returns></returns>
        public void BindShipment(IOpeartor operate)
        {
            operate.Op3("BindShipment");
            operate.Op2("BindShipment");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTest
{
    public class DealShipmentFactory
    {
        private IOpeartor ShipemntOperate { get; set; }
        private IDealShipment DealShipment { get; set; }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type">处理运单 type</param>
        public DealShipmentFactory(int type1, int type2)
        {
            switch (type1)
            {
                case 1:
                    ShipemntOperate = new FirstOpeartor();
                    DealShipment = new FirstDealShipment();
                    break;
                case 2:
                    ShipemntOperate = new SecondOpeartor();
                    DealShipment = new SecondDealShipment();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 处理运单
        /// </summary>
        /// <returns></returns>
        public void ShipmentGen()
        {
            DealShipment.ShipmentGen(ShipemntOperate);
        }

        /// <summary>
        /// 绑定运单
        /// </summary>
        public void BindShipment()
        {
            DealShipment.BindShipment(ShipemntOperate);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderDistrubution.Deal;
using OrderDistrubution.Opeartor;

namespace OrderDistrubution
{
    /// <summary>
    /// Deal运单工厂
    /// </summary>
    public class DealShipmentFactory
    {

        private IOpeartor ShipemntOperate { get; set; }
        private IDealShipment DealShipment { get; set; }
        private object Dto { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type">处理运单 type</param>
        /// <param name="dto">业务数据</param>
        /// <remarks>type可以和dto合一</remarks>
        public DealShipmentFactory(int type, object dto)
        {
            switch (type)
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
            Dto = dto;
        }

        /// <summary>
        /// 处理运单
        /// </summary>
        /// <returns></returns>
        public void ShipmentGen()
        {
            DealShipment.ShipmentGen(ShipemntOperate, Dto);
        }

        /// <summary>
        /// 绑定运单
        /// </summary>
        public void BindShipment()
        {
            DealShipment.BindShipment(ShipemntOperate, Dto);
        }
    }
}

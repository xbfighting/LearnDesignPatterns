using OrderDistrubution.Opeartor;

namespace OrderDistrubution.Deal
{
    /// <summary>
    /// 第二类订单分配实例
    /// </summary>
    public class SecondDealShipment : IDealShipment
    {
        /// <summary>
        /// 运单生成
        /// </summary>
        /// <param name="operate">操作类</param>
        /// <param name="dto"></param>
        /// <returns></returns>
        public void ShipmentGen(IOpeartor operate, object dto)
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
        /// <param name="dto"></param>
        /// <returns></returns>
        public void BindShipment(IOpeartor operate, object dto)
        {
            operate.Op3("BindShipment");
            operate.Op2("BindShipment");
        }
    }
}

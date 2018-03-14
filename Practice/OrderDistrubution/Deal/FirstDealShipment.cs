using OrderDistrubution.Opeartor;

namespace OrderDistrubution.Deal
{
    /// <summary>
    /// 第一类订单分配实例
    /// </summary>
    public class FirstDealShipment : IDealShipment
    {
        /// <summary>
        /// 运单生成
        /// </summary>
        /// <param name="operate">操作类</param>
        /// <param name="dto"></param>
        /// <returns></returns>
        public void ShipmentGen(IOpeartor operate, object dto)
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
        /// <param name="dto"></param>
        /// <returns></returns>
        public void BindShipment(IOpeartor operate, object dto)
        {
            operate.Op2("BindShipment");
            operate.Op3("BindShipment");
        }
    }
}

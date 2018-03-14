using System;
using OrderDistrubution.Opeartor;

namespace OrderDistrubution.Deal
{
    /// <summary>
    /// Deal 运单接口
    /// </summary>
    public interface IDealShipment
    {
        /// <summary>
        /// 订单生成运单
        /// </summary>
        /// <param name="operate">操作类</param>
        /// <param name="dto">业务数据</param>
        /// <returns></returns>
        void ShipmentGen(IOpeartor operate, object dto);

        /// <summary>
        /// 订单绑定到绑定运单
        /// </summary>
        /// <param name="operate">操作类</param>
        /// <param name="dto">业务数据</param>
        /// <returns></returns>
        void BindShipment(IOpeartor operate, object dto);
    }
}

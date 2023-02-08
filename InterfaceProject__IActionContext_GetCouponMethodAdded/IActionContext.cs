namespace InterfaceProject;
public interface IActionContext
{
    int BlockIndex { get; }

    Coupon GetCoupon();
}

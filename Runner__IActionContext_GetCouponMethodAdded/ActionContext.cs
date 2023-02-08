using InterfaceProject;

namespace Runner;

class ActionContext : IActionContext
{
    public int BlockIndex { get; }

    public Coupon GetCoupon()
    {
        return new Coupon();
    }
}

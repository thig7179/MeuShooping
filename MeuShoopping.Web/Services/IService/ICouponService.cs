using MeuShoopping.Web.Models;

namespace MeuShoopping.Web.Services.IService
{
    public interface ICouponService
    {
        Task<CouponViewModel> GetCoupon(string code, string token);
    }
}

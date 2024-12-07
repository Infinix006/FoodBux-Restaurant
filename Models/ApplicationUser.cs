using Microsoft.AspNetCore.Identity;

namespace FoodBux_Restaurent.Models
{
    public class ApplicationUser:IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}

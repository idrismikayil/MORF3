using Domain.Enums;

namespace Domain.Entities
{
    public class Customer : User
    {
        public Roles Role { get; set; } = Roles.CUSTOMER;
        public DateTime ExpirationDate { get; set; }
    }
}

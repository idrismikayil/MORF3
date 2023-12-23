namespace Domain.Entities
{
    public class Portfolio : BaseEntity
    {
        public string Title { get; set; }
        //Text table?
        public IEnumerable<Image<Portfolio>> Images { get; set; }
    }
}

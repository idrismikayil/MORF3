namespace Domain.Entities
{
    public class Portfolio : BaseEntity
    {
        public string Title { get; set; }
        public IEnumerable<string> Texts { get; set; }
        public IEnumerable<Image<Portfolio>> Images { get; set; }
    }
}

namespace CqrsDemo.Entities
{
    public class Order:BaseEntity
    {
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}

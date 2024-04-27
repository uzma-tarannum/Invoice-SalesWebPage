namespace WebApplication1.Models.Entitties
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryCode { get; set; }
        public int BrandCode { get; set; }
        public decimal SalesRate { get; set; }
        public decimal CostRate { get; set; }
        public decimal Total { get; set; }
    }
}

namespace WebApplication1.ViewModels
{
    public class ProductViewModel
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int CategoryCode { get; set; }
        public int BrandCode { get; set; }
        public byte ImagePath { get; set; }
        public decimal SalesRate { get; set; }
        public decimal CostRate { get; set; }
        public decimal Total { get; set; }
    }
}

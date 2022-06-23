using EntityLayer.Concrete;

namespace UI.Models
{
    public class ProductAddModel
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public bool Status { get; set; }
        public int ColorId { get; set; }
        public List<Size> SelectedSize { get; set; }
    }
}

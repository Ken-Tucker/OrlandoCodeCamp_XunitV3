namespace XunitDemo.Models
{
    public class Product
    {
        public int entityId { get; set; }
        public float unitPrice { get; set; }
        public int categoryId { get; set; }
        public int supplierId { get; set; }
        public string productName { get; set; }
        public string discontinued { get; set; }
        public object reorderLevel { get; set; }
        public object unitsInStock { get; set; }
        public object unitsOnOrder { get; set; }
        public object quantityPerUnit { get; set; }
    }

}

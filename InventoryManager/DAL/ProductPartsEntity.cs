namespace JasonNealC968.DAL
{
    public class ProductPartsEntity
    {
        public int ProductID { get; set; }
        public int PartID { get; set; }
        public ProductEntity? Product { get; set; }
        public PartEntity? Part { get; set; }
    }
}

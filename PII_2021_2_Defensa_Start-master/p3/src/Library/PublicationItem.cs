namespace Ucu.Poo.Defense
{
    /// <summary>
    /// Esta clase se encarga de calcular el precio por item porque tiene la información necesaria, precio y cantidad,
    /// así se cumple con el patrón Expert.
    /// </summary>
    public class PublicationItem
    {
        public Material Material { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public PublicationItem(Material material, int quantity, int price)
        {
            this.Material = material;
            this.Quantity = quantity;
            this.Price = price;
        }
        public int Total()
        {
            int precioTotalItem = this.Quantity * this.Price;
            return precioTotalItem;
        }
    }
}
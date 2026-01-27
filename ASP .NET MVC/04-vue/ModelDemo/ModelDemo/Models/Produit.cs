namespace ModelDemo.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
       
        public int Stock {  get; set; }
        public bool IsAvailable => Stock > 0;

        public decimal Prix { get; set; }

        public string StockStatus
        {
            get
            {
                if (Stock <= 0) return "Rupture";
                if (Stock < 5) return "Stock faible";
                return "En stock";
            }
        }


        public string StockCssClass
        {
            get
            {
                if (StockStatus.Equals("Rupture")) return "bg-danger";
                if (StockStatus.StartsWith("Stock")) return "bg-warning";
                return "bg-success";
            }
        }


        public string PriceFormatted
        {
            get
            {
                return Prix.ToString("C");
            }
        }

        public bool IsExpensive => Prix > 500;

        public string PriceCssClass
        {
            get
            {
                if (IsExpensive) return "text-danger";
                return "text-success";
            }
        }
    }
}

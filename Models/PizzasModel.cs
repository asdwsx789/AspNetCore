namespace Pizza.Model
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public int BasePrice { get; set; } = 60;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Mushromm { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }

        public int FinalPrice { get; set; }
    }
}
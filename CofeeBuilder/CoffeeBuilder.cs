namespace CofeeBuilder
{
    public class CoffeeBuilder
    {
        private string sort = null!;
        private List<Milk> milks = new List<Milk>();
        private List<Sugar> sugars = new List<Sugar>();

        public CoffeeBuilder SetBlackCoffee()
        {
            sort = "Black";
            milks.Clear();
            sugars.Clear();
            return this;
        }

        public CoffeeBuilder SetCubanoCoffee()
        {
            sort = "Cubano";
            milks.Clear();
            sugars.Clear();
            sugars.Add(new Sugar("Brown"));
            return this;
        }

        public CoffeeBuilder SetAntoccinoCoffee()
        {
            sort = "Americano";
            milks.Clear();
            sugars.Clear();
            milks.Add(new Milk(0.5));
            return this;
        }

        public CoffeeBuilder WithMilk(double fat)
        {
            milks.Add(new Milk(fat));
            return this;
        }

        public CoffeeBuilder WithSugar(string sort)
        {
            sugars.Add(new Sugar(sort));
            return this;
        }

        public Coffee Build() => new Coffee(sort, milks, sugars);
    }
}
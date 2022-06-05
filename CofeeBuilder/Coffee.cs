namespace CofeeBuilder
{
    public struct Coffee
    {
        public string Sort;
        internal List<Milk> Milk;
        internal List<Sugar> Sugar;

        internal Coffee(string sort, List<Milk> milk, List<Sugar> sugar)
        {
            Sort = sort;
            Milk = milk;
            Sugar = sugar;
        }
    }
}
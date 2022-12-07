namespace DesignPatternsInCSharp.Models
{
    public abstract class ACreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}

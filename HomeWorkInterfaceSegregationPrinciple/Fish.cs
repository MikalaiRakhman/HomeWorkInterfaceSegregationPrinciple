namespace HomeWorkInterfaceSegregationPrinciple
{
    // Interface Segregation Principle. In this case it is better not to implement IScreamable interface. Because *Fish can't do any scream and this interface is useless
    public class Fish: IScreamable
    {
        public string DoScream()
        {
            return string.Empty;
        }
    }
}

namespace DrinkTypes.Models
{
    public class Soda : Drink
    {
        public override string GetDescription() => $"{Name}, {IsCarbonatedString}";

        public Soda(string name, bool isCarbonated) : base(name, isCarbonated)
        {
        }
    }
}
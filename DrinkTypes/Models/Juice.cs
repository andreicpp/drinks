namespace DrinkTypes.Models
{
    public enum JuiceIngredient {Aloe, Apple, Cherry, Grape, Papaya, Orange, Tomato};
    
    public class Juice : Drink
    {
        private readonly JuiceIngredient _madeFrom;
        public JuiceIngredient MadeFrom => _madeFrom;
        
        public override string GetDescription() => $"{Name}, {IsCarbonatedString}, made from {MadeFrom}";

        public Juice(string name, bool isCarbonated, JuiceIngredient madeFrom) : base(name, isCarbonated)
        {
            this._madeFrom = madeFrom;
        }
    }
}
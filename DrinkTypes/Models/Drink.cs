using System;

namespace DrinkTypes.Models
{
    public abstract class Drink
    {
        private readonly string _name;
        public string Name => _name;

        private readonly bool _isCarbonated;
        public bool IsCarbonated => _isCarbonated;

        protected string IsCarbonatedString => $"{(IsCarbonated ? "" : "not ")}carbonated";
        
        public abstract string GetDescription();

        protected Drink(string name, bool isCarbonated)
        {
            if(string.IsNullOrEmpty(name))
                throw new Exception($"{this.GetType().Name} cant have null or empty name property");
            
            this._name = name;
            this._isCarbonated = isCarbonated;
        }
    }
}
using System;

namespace DrinkTypes.Models
{
    public class Beer : Drink
    {
        private readonly double _alcoholContent;
        public double AlcoholContent => _alcoholContent;
        
        public override string GetDescription() => $"{Name}, {IsCarbonatedString}, {AlcoholContent}%";
        
        public Beer(string name, bool isCarbonate, double alcoholContent = 0) : base(name, isCarbonate)
        {
            // 67.5% alcohol is the world strongest beer, proofed by google :)
            if(alcoholContent < 0 || alcoholContent > 67.5) 
                throw new Exception($"Beer with {alcoholContent}% of alcohol not exists");
            
            this._alcoholContent = alcoholContent;
        }
    }
}
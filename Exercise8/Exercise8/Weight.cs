using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise8
{
    class Weight
    {
        private double weight = 0; // Nullable Type

        public void SetWeight(WeightUnit weightUnit, double newWeight)
        {
            switch (weightUnit)
            {
                case WeightUnit.Kilogram:
                    weight = newWeight; 
                    break;
                case WeightUnit.Pound:
                    weight = newWeight * 0.45359237;
                    break;
                case WeightUnit.Gram:
                    weight = newWeight / 1000;
                    break;
                case WeightUnit.Ounce:
                    weight = newWeight * 0.0283495231;
                    break;
            }
        }

        public void Add(WeightUnit weightUnit, double p)
        {
            switch (weightUnit)
            {
                case WeightUnit.Kilogram:
                    weight += p;
                    break;
                case WeightUnit.Pound:
                    weight += p * 0.45359237;
                    break;
                case WeightUnit.Gram:
                    weight = p / 1000;
                    break;
                case WeightUnit.Ounce:
                    weight = p * 0.0283495231;
                    break;
            }
        }

        public double GetWeight(WeightUnit weightUnit)
        {
            switch (weightUnit)
            {
                case WeightUnit.Kilogram:
                    return weight;
                    break;
                case WeightUnit.Pound:
                    return (weight*2.20462262);
                    break;
                case WeightUnit.Gram:
                    return (weight * 1000);
                    break;
                case WeightUnit.Ounce:
                    return (weight * 35.2739619);
                    break;
                default: 
                    throw new NotImplementedException();
                    break;
            }
        }

        public void Add(Weight w)
        {
            weight += w.GetWeight(WeightUnit.Kilogram);
        }
        
        public void SetWeight(Weight w)
        {
            SetWeight(WeightUnit.Kilogram, w.GetWeight(WeightUnit.Kilogram));
        }

        public static Weight operator +(Weight leftWeight, Weight rightWeight)
        {
            Weight sumWeight = new Weight();

            sumWeight.SetWeight(WeightUnit.Kilogram, leftWeight.GetWeight(WeightUnit.Kilogram) + rightWeight.GetWeight(WeightUnit.Kilogram));
            
            return sumWeight;
        }
    }
}

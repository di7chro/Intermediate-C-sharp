using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise5
{
    class Weight
    {
        private double weight = 0; // Nullable Type

        public void SetWeight(WeightUnit weightUnit, double p)
        {
            switch (weightUnit)
            {
                case WeightUnit.Kilogram:
                    weight = p; 
                    break;
                case WeightUnit.Pound:
                    weight = p * 0.45359237;
                    break;
                case WeightUnit.Gram:
                    weight = p / 1000;
                    break;
                case WeightUnit.Ounce:
                    weight = p * 0.0283495231;
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
    }
}

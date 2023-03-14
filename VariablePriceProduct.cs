

namespace OOPExerciceC
{
    public class VariablePriceProduct : Product
    {
        private decimal _pricePerUnitOfMeasure;
        private float _quantity;


        public decimal PricePerUnitOfMeasure
        {
            get => _pricePerUnitOfMeasure;
            set => _pricePerUnitOfMeasure = ValidateGreatherThanZero(value);
        }

        public float Quantity
        {
            get => _quantity;
            set => _quantity = ValidateGreatherThanZero(value);
        }

        public string? UnitOfMeasure { get; set; }


        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Unit of eeasure......:{UnitOfMeasure}\n\t" +
                $"Quantity.............:{Quantity,20}\n\t" +
                $"Price................:{PricePerUnitOfMeasure,20:c2}\n\t" +
                $"Discount value.......:{CalculateDiscount(),20:c2}\n\t" +
                $"Tax value............:{CalculateTax(),20:c2}\n\t" +
                $"Value to pay.........:{CalculateValueToPay(),20:C2}\n\t";

        }

        public override decimal CalculateDiscount()
        {
            return PricePerUnitOfMeasure * (decimal)Quantity * (decimal)DiscountPercentaje;
        }

        public override decimal CalculateTax()
        {
            return PricePerUnitOfMeasure * (decimal)Quantity * (decimal)TaxPercentaje;
        }

        public override decimal CalculateValueToPay()
        {
            return PricePerUnitOfMeasure * (decimal)Quantity - CalculateDiscount() + CalculateTax();
        }

        private decimal ValidateGreatherThanZero(decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("the price per unit can´t be zero.");
            }
            return value;
        }

        private float ValidateGreatherThanZero(float value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("the quantity is not valid.");
            }
            return value;
        }

    }

}

namespace OOPExerciceC
{
    public class FixedPriceProduct : Product
    {
        private decimal _price;

        public decimal Price
        {
            get => _price;
            set => _price = ValidateGreatherThanZero(value);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Price................:{Price,20:C2}\n\t" +
                $"Discount value.......:{CalculateDiscount(),20:C2}\n\t" +
                $"Tax value............:{CalculateTax(),20:C2}\n\t" +
                $"Value to pay.........:{CalculateValueToPay(),20:C2}\n\t";
        }


        public override decimal CalculateDiscount()
        {
            return Price * (decimal)DiscountPercentaje;
        }

        public override decimal CalculateTax()
        {
            return Price * (decimal)TaxPercentaje;
        }

        public override decimal CalculateValueToPay()
        {
            return Price - CalculateDiscount() + CalculateTax();
        }

        private decimal ValidateGreatherThanZero(decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("the price is less than zero");
            }
            return value;
        }
    }

}

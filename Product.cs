

namespace OOPExerciceC
{
    public abstract class Product : IProduct
    {
        private float _discountPercentaje;
        private float _taxPercentaje;


        public float DiscountPercentaje
        {
            get => _discountPercentaje;
            set => _discountPercentaje = ValidatePercentaje(value);
        }

        public int Id { get; set; }

        public string? Name { get; set; }

        public float TaxPercentaje
        {
            get => _taxPercentaje;
            set => _taxPercentaje = ValidatePercentaje(value);
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\n\t" +
                $"% Discount...........: {DiscountPercentaje,20:p2}\n\t" +
                $"% Tax................: {TaxPercentaje,20:p2}\t";
        }

        public abstract decimal CalculateDiscount();
        public abstract decimal CalculateTax();
        public abstract decimal CalculateValueToPay();


        private float ValidatePercentaje(float value)

        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("the percentaje is not Valid.");
            }
            return value;
        }


    }

}

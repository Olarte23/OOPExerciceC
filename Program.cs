using OOPExerciceC;

Console.WriteLine("***************************************************");
Console.WriteLine("*                   Supermarket                   *");
Console.WriteLine("***************************************************");

Product[] products = new Product[]
{
    new FixedPriceProduct
    {
        Id = 1,
        Name = "Coca Cola",
        DiscountPercentaje = 0.1f,
        TaxPercentaje = 0.05f,
        Price = 2500
    },
    new FixedPriceProduct
    {
        Id = 2,
        Name = "Leche",
        DiscountPercentaje = 0.2f,
        TaxPercentaje = 0,
        Price = 5000
    },
    new FixedPriceProduct
    {
        Id = 3,
        Name = "Pan",
        DiscountPercentaje = 0,
        TaxPercentaje = 0.12f,
        Price = 3000
    },
    new VariablePriceProduct
    {
        Id = 4,
        Name = "Carne",
        UnitOfMeasure = "Kilo",
        PricePerUnitOfMeasure = 22000,
        Quantity = 2.5f,
        DiscountPercentaje = 0.3f,
        TaxPercentaje = 0.12f
    },
    new VariablePriceProduct
    {
        Id = 5,
        Name = "Alambre",
        UnitOfMeasure = "Metros",
        PricePerUnitOfMeasure = 5600,
        Quantity = 30.8f,
        DiscountPercentaje = 0.25f,
        TaxPercentaje = 0.07f
    },
};

decimal totalDiscount = 0;
decimal totalTax = 0;
decimal totalValue = 0;
foreach (var product in products)
{
    Console.WriteLine(product);
    totalDiscount += product.CalculateDiscount();
    totalTax += product.CalculateTax();
    totalValue += product.CalculateValueToPay();
}

Console.WriteLine($"                                ===================");
Console.WriteLine($"Total Discount                 {totalDiscount,20:C2}");
Console.WriteLine($"Total Tax                      {totalTax,20:C2}");
Console.WriteLine($"Total Value                    {totalValue,20:C2}");

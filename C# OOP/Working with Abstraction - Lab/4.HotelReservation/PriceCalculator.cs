public class PriceCalculator
{
    public decimal CalculatePrice(decimal price, int numberOfDays, Season season, Discount discount)
    {
        price *= numberOfDays * (int)season;
        decimal discountAmount = price * (decimal)((decimal)discount / 100);
        return price - discountAmount;
    }
}


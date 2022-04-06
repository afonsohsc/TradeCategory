namespace TradeCategory
{
    static class Category
    {
        public static string CategoryName(ITrade trade, DateTime referenceDate)
        {
            List<ICategory> categories= new List<ICategory> {
                new PEPCategory(trade),
                new ExpiredCategory(trade, referenceDate),
                new MediumRiskCategory(trade),
                new HighRiskCategory(trade)
            };

            foreach (var category in categories)
            {
                if (!string.IsNullOrEmpty(category.CategoryName()))
                    return category.CategoryName();
            }

            return string.Empty;
        }
    }
}

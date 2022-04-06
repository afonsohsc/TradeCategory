namespace TradeCategory
{
    public class ExpiredCategory : ICategory
    {
        private readonly ITrade _trade;
        private readonly DateTime _referenceDate;

        public ExpiredCategory(ITrade trade, DateTime referenceDate)
        {
            _trade = trade;
            _referenceDate = referenceDate;
        }

        public string CategoryName()
        {
            if (_referenceDate.Subtract(_trade.NextPaymentDate).TotalDays > 30)
            {
                return "EXPIRED";
            }

            return string.Empty;
        }
    }
}

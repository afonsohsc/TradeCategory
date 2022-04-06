namespace TradeCategory
{
    public class HighRiskCategory : ICategory
    {
        private readonly ITrade _trade;

        public HighRiskCategory(ITrade trade)
        {
            _trade = trade;
        }

        public string CategoryName()
        {
            if (_trade.Value > 1000000 && _trade.ClientSector.Equals("PRIVATE", StringComparison.InvariantCultureIgnoreCase))
            {
                return "HIGHRISK";
            }

            return string.Empty;
        }
    }
}

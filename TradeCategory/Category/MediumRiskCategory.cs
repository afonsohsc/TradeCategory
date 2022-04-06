namespace TradeCategory
{
    public class MediumRiskCategory : ICategory
    {
        private readonly ITrade _trade;

        public MediumRiskCategory(ITrade trade)
        {
            _trade = trade;
        }

        public string CategoryName()
        {
            if (_trade.Value > 1000000 && _trade.ClientSector.Equals("PUBLIC", StringComparison.InvariantCultureIgnoreCase))
            {
                return "MEDIUMRISK";
            }

            return string.Empty;
        }
    }
}

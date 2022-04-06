namespace TradeCategory
{
    public class PEPCategory : ICategory
    {
        private readonly ITrade _trade;

        public PEPCategory(ITrade trade)
        {
            _trade = trade;
        }

        public string CategoryName()
        {
            if (_trade.IsPoliticallyExposed)
            {
                return "PEP";
            }

            return string.Empty;
        }
    }
}

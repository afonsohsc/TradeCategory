namespace TradeCategory
{
    public class Trade : ITrade
    {
        private double _value;
        public double Value
        {
            get { return _value; }
        }

        private string _clientSector;
        public string ClientSector
        {
            get { return _clientSector; }
        }

        private DateTime _nextPaymentDate;
        public DateTime NextPaymentDate
        {
            get { return _nextPaymentDate; }
        }

        private bool _isPoliticallyExposed;
        public bool IsPoliticallyExposed
        {
            get { return _isPoliticallyExposed; }
        }

        public Trade(string trade)
        {
            var tradeInputs = trade.Split(' ');
            _value = Convert.ToDouble(tradeInputs[0]);
            _clientSector = tradeInputs[1];
            _nextPaymentDate = DateTime.ParseExact(tradeInputs[2], "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var isPoliticallyExposed = false;
            Boolean.TryParse(tradeInputs.LastOrDefault(), out isPoliticallyExposed);
            _isPoliticallyExposed = isPoliticallyExposed;
        }

        public Trade(double value, string clientSector, DateTime nextPaymentDate)
        {
            _value = value;
            _clientSector = clientSector;
            _nextPaymentDate = nextPaymentDate;
        }

        public Trade(double value, string clientSector, DateTime nextPaymentDate, bool isPoliticallyExposed)
        {
            _value = value;
            _clientSector = clientSector;
            _nextPaymentDate = nextPaymentDate;
            _isPoliticallyExposed = isPoliticallyExposed;
        }

        public string CategoryName(DateTime referenceDate)
        {
            return Category.CategoryName(this, referenceDate);
        }

    }
}

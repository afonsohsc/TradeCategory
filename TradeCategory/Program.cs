using TradeCategory;

Console.Title = "Categories of Trades";
Console.WriteLine("Categorize trades in a bank´s portfolio:");
Console.WriteLine();

List<Trade> portfolio = new();

Console.Write("Reference date: ");
var referenceDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);

Console.Write("Number of trades in the portfolio: ");
int numberTradesPortfolio = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numberTradesPortfolio; i++)
{
    Console.Write("Trade: ");
    portfolio.Add(new Trade(Console.ReadLine()));
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Output Category:");

foreach (var trade in portfolio)
{
    Console.WriteLine(trade.CategoryName(referenceDate));
}

Console.ReadKey();
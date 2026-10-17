using static LINQ.DataSources.Source;
namespace G_NET_84_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment

            #region Q1

            //var seafood = ProductList.Where(p => p.Category == "Seafood");

            //seafood = from p in ProductList
            //          where p.Category == "Seafood"
            //          select p;

            //foreach (var product in seafood)
            //    Console.WriteLine($"{product.ProductName} => {product.UnitPrice:C2}");
            #endregion

            #region Q2

            //var names = ProductList.Select(p => p.ProductName);

            //names = from p in ProductList
            //        select p.ProductName;

            //foreach (var name in names)
            //    Console.WriteLine(name);
            #endregion

            #region Q3 - UnitPrice between 10 and 30

            var midPriced = ProductList.Where(p => p.UnitPrice >= 10m && p.UnitPrice <= 30m);

            midPriced = from p in ProductList
                        where p.UnitPrice >= 10m && p.UnitPrice <= 30m
                        select p;

            foreach (var product in midPriced)
                Console.WriteLine(product);
            #endregion

            #region Q4 - In stock AND Condiments

            var inStockCondiments = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments");

            inStockCondiments = from p in ProductList
                                where p.UnitsInStock > 0 && p.Category == "Spices & Condiments"
                                select p;

            foreach (var product in inStockCondiments)
                Console.WriteLine(product);
            #endregion

            #region Q5 - Anonymous type (Name, Price, StockStatus)

            var stockInfo = ProductList.Select(p => new
            {
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            });

            stockInfo = from p in ProductList
                        select new
                        {
                            Name = p.ProductName,
                            Price = p.UnitPrice,
                            StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
                        };

            foreach (var item in stockInfo)
                Console.WriteLine(item);
            #endregion

            #endregion
        }
    }
}

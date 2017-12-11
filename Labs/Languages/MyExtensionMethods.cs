using System.Collections.Generic;



namespace EssentialLanguageChapter4.Models
{
    public static class MyExtensionMethods
    {

        public static decimal TotalPrices(this IEnumerable<Product> productEnum)
        {
            decimal total = 0; foreach (Product prod in productEnum) { total += prod.Price; }
            return total;
        }
    }
}
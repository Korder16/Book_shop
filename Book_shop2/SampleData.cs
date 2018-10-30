using System.Linq;
using Book_shop2.Models;


namespace Book_shop2
{
    public static class SampleData
    {
        public static void Initialize(MyBookShopContext context)
        {
            if (!context.Purchase.Any())
            {
                context.Purchase.AddRange(
                    );
            }
        }
    }
}
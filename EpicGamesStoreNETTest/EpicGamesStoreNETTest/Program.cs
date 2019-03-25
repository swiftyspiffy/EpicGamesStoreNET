using System;

namespace EpicGamesStoreNETTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Title = "EpicGamesStoreNET Test/Demonstration Project";

                Console.WriteLine("Enter Epic Games Store query:");
                var query = Console.ReadLine();
                Console.WriteLine();

                // async: EpicGamesStoreNET.Query.SearchAsync(query);
                var resp = EpicGamesStoreNET.Query.Search(query);
                var listings = resp.Data.Catalog.CatalogOffers.Elements;

                Console.WriteLine($"Search results returned: {resp.Data.Catalog.CatalogOffers.Elements.Length}");
                Console.WriteLine("----------------");
                foreach (var result in listings)
                {
                    Console.WriteLine($"Game: {result.Title} (categories: {string.Join<EpicGamesStoreNET.Models.Category>(", ", result.Categories)})");
                    // sometimes epic store doesn't have a price, so the Price field is null. YOU SHOULD HANDLE THIS CASE
                    if (result.Price != null)
                        Console.WriteLine($"Price: {result.Price.TotalPrice.FmtPrice.DiscountPrice} (normal: {result.Price.TotalPrice.FmtPrice.OriginalPrice})");
                    else
                        Console.WriteLine("Price: no price supplied");
                    Console.WriteLine($"Link: https://www.epicgames.com/store/en-US/product/{result.ProductSlug}");
                    Console.WriteLine("----------------");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}

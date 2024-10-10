using e.Models;
using HtmlAgilityPack;
using System.Globalization;

public class UltraMdRefrigeratorService
{
    private readonly HttpClient _httpClient;

    public UltraMdRefrigeratorService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<UltraRefrigeratorModel>> ScrapeProductsAsync()
    {
        var products = new List<UltraRefrigeratorModel>();
        string url = "https://ultra.md/category/refrigerators-xolodilniki?page=1";
        var response = await _httpClient.GetStringAsync(url);

        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(response);

        var productNodes = htmlDoc.DocumentNode.SelectNodes("//div[contains(@class, 'product-block')]");
        int i = 0;
        foreach (var productNode in productNodes)
        {
            var product = new UltraRefrigeratorModel();

            var titleNode = productNode.SelectSingleNode(".//following-sibling::a[contains(@class, 'product-text') and starts-with(text(), 'Frigider')]");

            if (titleNode != null)
            {
                product.Title = titleNode.InnerText.Trim();
                product.Link = titleNode.GetAttributeValue("href", string.Empty);
            }
            else
            {
                Console.WriteLine("Title node not found.");
                continue;
            }
            if (products.Any(p => p.Link == product.Link))
            {
                //Console.WriteLine($"Duplicate product found: {product.Title}");
                continue;
            }

            decimal ParsePrice(string input)
            {
                return decimal.Parse(input?.Replace("lei", "").Replace("lei/luni", "").Replace(" ", "").Trim(), CultureInfo.InvariantCulture);
            }

            var discountNode = productNode.SelectSingleNode(".//span[contains(@class, 'bg-red-500')]");
            var pricePerMonthNode = productNode.SelectSingleNode(".//span[contains(text(), 'lei/luni')]/preceding-sibling::span");

            if (discountNode != null)
            {
                var discountedPriceNode = productNode.SelectSingleNode(".//span[contains(@class, 'font-bold')]");
                var standardPriceNode = productNode.SelectSingleNode(".//span[contains(@class, 'line-through')]");

                try
                {
                    product.Price = ParsePrice(standardPriceNode?.InnerText);
                    product.DiscountPrice = ParsePrice(discountedPriceNode?.InnerText);
                    product.DiscountPercentage = discountNode.InnerText.Trim();
                    product.PricePerMonth = ParsePrice(pricePerMonthNode?.InnerText);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Format exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                var standardPriceNode = productNode.SelectSingleNode(".//span[contains(@class, 'text-blue') and contains(@class, 'font-bold')]");
                if (standardPriceNode != null)
                {
                    product.Price = ParsePrice(standardPriceNode.InnerText);
                    product.PricePerMonth = ParsePrice(pricePerMonthNode?.InnerText);
                }
            }
            products.Add(product);
            i++;
        }
        return products;
    }
}

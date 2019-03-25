using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpicGamesStoreNET.Models
{
    public class Response
    {
        [JsonProperty(PropertyName = "data")]
        public Data Data { get; protected set; }
    }

    public class Data
    {
        [JsonProperty(PropertyName = "catalog")]
        public Catalog Catalog { get; protected set; }
    }

    public class Catalog
    {
        [JsonProperty(PropertyName = "catalogOffers")]
        public CatalogOffers CatalogOffers { get; protected set; }
    }

    public class CatalogOffers
    {
        [JsonProperty(PropertyName = "elements")]
        public Element[] Elements { get; protected set; }
    }

    public class Element
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; protected set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; protected set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }
        [JsonProperty(PropertyName = "price")]
        public Price Price { get; protected set; }
        [JsonProperty(PropertyName = "productSlug")]
        public string ProductSlug { get; protected set; }
        [JsonProperty(PropertyName = "categories")]
        public Category[] Categories { get; protected set; }
    }

    public class Price
    {
        [JsonProperty(PropertyName = "totalPrice")]
        public TotalPrice TotalPrice { get; protected set; }
    }

    public class TotalPrice
    {
        [JsonProperty(PropertyName = "discountPrice")]
        public int DiscountPrice { get; protected set; }
        [JsonProperty(PropertyName = "originalPrice")]
        public int OriginalPrice { get; protected set; }
        [JsonProperty(PropertyName = "fmtPrice")]
        public FmtPrice FmtPrice { get; protected set; }
    }

    public class FmtPrice
    {
        [JsonProperty(PropertyName = "originalPrice")]
        public string OriginalPrice { get; protected set; }
        [JsonProperty(PropertyName = "discountPrice")]
        public string DiscountPrice { get; protected set; }
    }

    public class Category
    {
        [JsonProperty(PropertyName = "path")]
        public string Path;

        public override string ToString()
        {
            return Path;
        }
    }
}

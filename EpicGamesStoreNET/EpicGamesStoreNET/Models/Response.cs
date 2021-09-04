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
        [JsonProperty(PropertyName = "Catalog")]
        public Catalog Catalog { get; protected set; }
    }

    public class Catalog
    {
        [JsonProperty(PropertyName = "searchStore")]
        public SearchStore SearchStore { get; protected set; }
    }

    public class SearchStore
    {
        [JsonProperty(PropertyName = "elements")]
        public Element[] Elements { get; protected set; }
    }

    public class Element
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; protected set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; protected set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; protected set; }
        [JsonProperty(PropertyName = "effectiveDate")]
        public DateTime EffectiveDate { get; protected set; }
        [JsonProperty(PropertyName = "keyImages")]
        public KeyImage[] KeyImages { get; protected set; }
        [JsonProperty(PropertyName = "currentPrice")]
        public int CurrentPrice { get; protected set; }
        [JsonProperty(PropertyName = "seller")]
        public Seller Seller { get; protected set; }
        [JsonProperty(PropertyName = "productSlug")]
        public string ProductSlug { get; protected set; }
        [JsonProperty(PropertyName = "urlSlug")]
        public string UrlSlug { get; protected set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; protected set; }
        [JsonProperty(PropertyName = "tags")]
        public Tag[] Tags { get; protected set; }
        [JsonProperty(PropertyName = "items")]
        public Item[] Items { get; protected set; }
        [JsonProperty(PropertyName = "customAttributes")]
        public CustomAttribute[] CustomAttributes { get; protected set; }
        [JsonProperty(PropertyName = "categories")]
        public Category[] Categories { get; protected set; }
        [JsonProperty(PropertyName = "catalogNs")]
        public CatalogNs CatalogNs { get; protected set; }
        [JsonProperty(PropertyName = "price")]
        public Price Price { get; protected set; }
    }

    public class KeyImage
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; protected set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; protected set; }
    }

    public class Seller
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }
    }

    public class Tag
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }
    }

    public class Item
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; protected set; }
    }

    public class CustomAttribute
    {
        [JsonProperty(PropertyName = "key")]
        public string Key { get; protected set; }
        [JsonProperty(PropertyName = "value")]
        public string Value { get; protected set; }
    }

    public class Category
    {
        [JsonProperty(PropertyName = "path")]
        public string Path { get; protected set; }
    }

    public class CatalogNs
    {
        [JsonProperty(PropertyName = "mappings")]
        public Mapping[] Mappings { get; protected set; }
    }

    public class Mapping
    {
        [JsonProperty(PropertyName = "pageSlug")]
        public string PageSlug { get; protected set; }
        [JsonProperty(PropertyName = "pageType")]
        public string PageType { get; protected set; }
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
        [JsonProperty(PropertyName = "voucherDiscount")]
        public int VoucherDiscount { get; protected set; }
        [JsonProperty(PropertyName = "discount")]
        public int Discount { get; protected set; }
        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; protected set; }
        [JsonProperty(PropertyName = "currencyInfo")]
        public CurrencyInfo CurrencyInfo { get; protected set; }
        [JsonProperty(PropertyName = "fmtPrice")]
        public FmtPrice FmtPrice { get; protected set; }
    }

    public class CurrencyInfo
    {
        [JsonProperty(PropertyName = "decimals")]
        public int Decimals { get; protected set; }
    }

    public class FmtPrice
    {
        [JsonProperty(PropertyName = "originalPrice")]
        public string OriginalPrice { get; protected set; }
        [JsonProperty(PropertyName = "discountPrice")]
        public string DiscountPrice { get; protected set; }
        [JsonProperty(PropertyName = "intermediatePrice")]
        public string IntermediatePrice { get; protected set; }
    }
}

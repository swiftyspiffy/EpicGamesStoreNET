using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpicGamesStoreNET.Models
{
    public class Request
    {
        [JsonProperty(PropertyName = "query")]
        //
        private string _gqlQuery { get { return "query searchStoreQuery($allowCountries: String, $category: String, $count: Int, $country: String!, $keywords: String, $locale: String, $namespace: String, $itemNs: String, $sortBy: String, $sortDir: String, $start: Int, $tag: String, $releaseDate: String, $withPrice: Boolean = false, $withPromotions: Boolean = false, $priceRange: String, $freeGame: Boolean, $onSale: Boolean, $effectiveDate: String) {\n  Catalog {\n    searchStore(\n      allowCountries: $allowCountries\n      category: $category\n      count: $count\n      country: $country\n      keywords: $keywords\n      locale: $locale\n      namespace: $namespace\n      itemNs: $itemNs\n      sortBy: $sortBy\n      sortDir: $sortDir\n      releaseDate: $releaseDate\n      start: $start\n      tag: $tag\n      priceRange: $priceRange\n      freeGame: $freeGame\n      onSale: $onSale\n      effectiveDate: $effectiveDate\n    ) {\n      elements {\n        title\n        id\n        namespace\n        description\n        effectiveDate\n        keyImages {\n          type\n          url\n        }\n        currentPrice\n        seller {\n          id\n          name\n        }\n        productSlug\n        urlSlug\n        url\n        tags {\n          id\n        }\n        items {\n          id\n          namespace\n        }\n        customAttributes {\n          key\n          value\n        }\n        categories {\n          path\n        }\n        catalogNs {\n          mappings(pageType: \"productHome\") {\n            pageSlug\n            pageType\n          }\n        }\n        offerMappings {\n          pageSlug\n          pageType\n        }\n        price(country: $country) @include(if: $withPrice) {\n          totalPrice {\n            discountPrice\n            originalPrice\n            voucherDiscount\n            discount\n            currencyCode\n            currencyInfo {\n              decimals\n            }\n            fmtPrice(locale: $locale) {\n              originalPrice\n              discountPrice\n              intermediatePrice\n            }\n          }\n          lineOffers {\n            appliedRules {\n              id\n              endDate\n              discountSetting {\n                discountType\n              }\n            }\n          }\n        }\n        promotions(category: $category) @include(if: $withPromotions) {\n          promotionalOffers {\n            promotionalOffers {\n              startDate\n              endDate\n              discountSetting {\n                discountType\n                discountPercentage\n              }\n            }\n          }\n          upcomingPromotionalOffers {\n            promotionalOffers {\n              startDate\n              endDate\n              discountSetting {\n                discountType\n                discountPercentage\n              }\n            }\n          }\n        }\n      }\n      paging {\n        count\n        total\n      }\n    }\n  }\n}\n"; } }
        [JsonProperty(PropertyName = "variables")]
        private Variables _variables { get; set; }

        public Request(string query)
        {
            _variables = new Variables(query);
        }

        private class Headers
        {
            [JsonProperty(PropertyName = "Content-Type")]
            private string _contentType { get { return "application/graphql"; } }
        }

        private class Variables
        {
            [JsonProperty(PropertyName = "category")]
            private string _category { get { return "games/edition/base|bundles/games|editors|software/edition/base"; } }
            [JsonProperty(PropertyName = "keywords")]
            private string _keywords { get; set; }
            [JsonProperty(PropertyName = "country")]
            private string _country { get { return "US"; } }
            [JsonProperty(PropertyName = "allowCountries")]
            private string _allowCountries { get { return "US"; } }
            [JsonProperty(PropertyName = "locale")]
            private string _locale { get { return "en-US"; } }
            [JsonProperty(PropertyName = "sortDir")]
            private string _sortDir { get { return "DESC"; } }
            [JsonProperty(PropertyName = "withPrice")]
            private bool _withPrice { get { return true; } }
            [JsonProperty(PropertyName = "withMapping")]
            private bool _withMapping { get { return true; } }

            public Variables(string query)
            {
                _keywords = query;
            }
        }
    }
}

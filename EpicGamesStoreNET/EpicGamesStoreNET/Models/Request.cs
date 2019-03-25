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
        private string _gqlQuery { get { return "\n        query searchQuery(\n            $namespace: String!, \n            $locale: String!, \n            $country: String!, \n            $query: String!,\n            \n    $hasCountryFilter: Boolean,\n    $filterCountry: String,\n    $filterAgeGroup: Int\n\n            )\n        { Catalog {\n            catalogOffers(namespace: $namespace, locale: $locale, params: {\n              keywords: $query,\n              country: $country\n            }, \ncountryAgeFilter: {\n    shouldCheck: $hasCountryFilter,\n    filterCountry: $filterCountry,\n    filterAgeGroup: $filterAgeGroup\n}\n) {\n                elements {\n                    url\n                    title\n                    id\n                    price(country: $country) {\n                        totalPrice {\n                            discountPrice\n                            originalPrice\n                            fmtPrice(locale:$locale) {\n                                originalPrice\n                                discountPrice\n                        }\n                        }\n                    }\n                    productSlug\n                    categories {\n                    path\n                    }\n                }\n            }\n          }\n        }"; } }
        [JsonProperty(PropertyName = "headers")]
        private Headers _headers { get { return new Headers();  } }
        [JsonProperty(PropertyName = "method")]
        private string _method { get { return "post";  } }
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
            [JsonProperty(PropertyName = "namespace")]
            private string _namespace { get { return "epic"; } }
            [JsonProperty(PropertyName = "locale")]
            private string _locale { get { return "en-US"; } }
            [JsonProperty(PropertyName = "query")]
            private string _query { get; set; }
            [JsonProperty(PropertyName = "country")]
            private string _country { get { return "US"; } }
            [JsonProperty(PropertyName = "hasCountryFilter")]
            private bool _hasCountryFilter { get { return false; } }
            [JsonProperty(PropertyName = "filterCountry")]
            private string _filterCoutnry { get { return null; } }
            [JsonProperty(PropertyName = "filterAgeGroup")]
            private string _filterAgeGroup { get { return null; } }

            public Variables(string query)
            {
                _query = query;
            }
        }
    }
}

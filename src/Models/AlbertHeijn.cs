﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var welcome = AlbertHeijn.FromJson(jsonString);

using System;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bot.Models
{
    public partial class AlbertHeijn
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("_meta")]
        public Meta Meta { get; set; }

        [JsonProperty("_links")]
        public WelcomeLinks Links { get; set; }

        [JsonProperty("_embedded")]
        public WelcomeEmbedded Embedded { get; set; }
    }

    public partial class WelcomeEmbedded
    {
        [JsonProperty("lanes")]
        public Lane[] Lanes { get; set; }
    }

    public partial class Lane
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("gutter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gutter { get; set; }

        [JsonProperty("expanded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expanded { get; set; }

        [JsonProperty("colorScheme", NullValueHandling = NullValueHandling.Ignore)]
        public ColorScheme ColorScheme { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("_embedded")]
        public LaneEmbedded Embedded { get; set; }

        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public string Layout { get; set; }

        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor { get; set; }
    }

    public partial class ColorScheme
    {
        [JsonProperty("baseColor")]
        public string BaseColor { get; set; }

        [JsonProperty("inverted")]
        public bool Inverted { get; set; }
    }

    public partial class LaneEmbedded
    {
        [JsonProperty("items")]
        public EmbeddedItem[] Items { get; set; }
    }

    public partial class EmbeddedItem
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Id { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Image Image { get; set; }

        [JsonProperty("navItem", NullValueHandling = NullValueHandling.Ignore)]
        public FilterNavItem NavItem { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("resourceType")]
        public SectionResourceType ResourceType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("shops", NullValueHandling = NullValueHandling.Ignore)]
        public Shop[] Shops { get; set; }

        [JsonProperty("autosuggest", NullValueHandling = NullValueHandling.Ignore)]
        public Self Autosuggest { get; set; }

        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public Search Search { get; set; }

        [JsonProperty("searchType", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchType { get; set; }

        [JsonProperty("frequentProductSearchTerms", NullValueHandling = NullValueHandling.Ignore)]
        public string[] FrequentProductSearchTerms { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor { get; set; }

        [JsonProperty("seoBreadcrumb", NullValueHandling = NullValueHandling.Ignore)]
        public SeoBreadcrumb[] SeoBreadcrumb { get; set; }

        [JsonProperty("foldOutChannelId", NullValueHandling = NullValueHandling.Ignore)]
        public string FoldOutChannelId { get; set; }

        [JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
        public ItemLinks Links { get; set; }

        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public string Context { get; set; }

        [JsonProperty("viewType", NullValueHandling = NullValueHandling.Ignore)]
        public string ViewType { get; set; }

        [JsonProperty("_embedded", NullValueHandling = NullValueHandling.Ignore)]
        public ItemEmbedded Embedded { get; set; }

        [JsonProperty("expanded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expanded { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }
    }

    public partial class Self
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public partial class ItemEmbedded
    {
        [JsonProperty("analytics", NullValueHandling = NullValueHandling.Ignore)]
        public EmbeddedAnalytics Analytics { get; set; }

        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public Product Product { get; set; }

        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public Filter[] Filters { get; set; }

        [JsonProperty("breadcrumbs", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Breadcrumbs { get; set; }

        [JsonProperty("sections", NullValueHandling = NullValueHandling.Ignore)]
        public Section[] Sections { get; set; }
    }

    public partial class EmbeddedAnalytics
    {
        [JsonProperty("originCode")]
        public string OriginCode { get; set; }
    }

    public partial class Filter
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("navItem")]
        public FilterNavItem NavItem { get; set; }

        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("_embedded")]
        public FilterEmbedded Embedded { get; set; }
    }

    public partial class FilterEmbedded
    {
        [JsonProperty("filterItems")]
        public object FilterItems { get; set; }
    }

    public partial class FilterNavItem
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Search Link { get; set; }
    }

    public partial class Search
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("pageType", NullValueHandling = NullValueHandling.Ignore)]
        public PageType? PageType { get; set; }
    }

    public partial class Product
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("unitSize")]
        public string UnitSize { get; set; }

        [JsonProperty("brandName")]
        public string BrandName { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("availability")]
        public Availability Availability { get; set; }

        [JsonProperty("priceLabel")]
        public PriceLabel PriceLabel { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }
    }

    public partial class Availability
    {
        [JsonProperty("orderable")]
        public bool Orderable { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public partial class Details
    {
        [JsonProperty("unitOfUseSize")]
        public string UnitOfUseSize { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("seoDescription")]
        public string SeoDescription { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("link")]
        public Self Link { get; set; }
    }

    public partial class PriceLabel
    {
        [JsonProperty("now")]
        public double Now { get; set; }
    }

    public partial class Section
    {
        [JsonProperty("resourceType")]
        public SectionResourceType ResourceType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("_embedded")]
        public SectionEmbedded Embedded { get; set; }
    }

    public partial class SectionEmbedded
    {
        [JsonProperty("content")]
        public Content[] Content { get; set; }
    }

    public partial class Content
    {
        [JsonProperty("text")]
        public Text Text { get; set; }

        [JsonProperty("resourceType")]
        public ContentResourceType ResourceType { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }
    }

    public partial class Text
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }
    }

    public partial class ItemLinks
    {
        [JsonProperty("add")]
        public Add Add { get; set; }
    }

    public partial class Add
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public partial class SeoBreadcrumb
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Shop
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public Tag Tag { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("navItem")]
        public ShopNavItem NavItem { get; set; }
    }

    public partial class ShopNavItem
    {
        [JsonProperty("link")]
        public Link Link { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("pageType")]
        public string PageType { get; set; }

        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class WelcomeLinks
    {
        [JsonProperty("self")]
        public Self Self { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("metaTags")]
        public MetaTags MetaTags { get; set; }

        [JsonProperty("analytics")]
        public MetaAnalytics Analytics { get; set; }

        [JsonProperty("page")]
        public Page Page { get; set; }
    }

    public partial class MetaAnalytics
    {
        [JsonProperty("baseUrl")]
        public string BaseUrl { get; set; }

        [JsonProperty("parameters")]
        public Parameters Parameters { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public partial class Parameters
    {
        [JsonProperty("ah_order_mode")]
        public string AhOrderMode { get; set; }

        [JsonProperty("ah_regtype")]
        public string AhRegtype { get; set; }

        [JsonProperty("ah_site")]
        public string AhSite { get; set; }

        [JsonProperty("ah_state")]
        public string AhState { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ns__t")]
        public string NsT { get; set; }

        [JsonProperty("ns_c")]
        public string NsC { get; set; }

        [JsonProperty("ns_jspageurl")]
        public string NsJspageurl { get; set; }

        [JsonProperty("ns_ti")]
        public string NsTi { get; set; }
    }

    public partial class MetaTags
    {
        [JsonProperty("items")]
        public MetaTagsItem[] Items { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public partial class MetaTagsItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public partial class Page
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("taxonomyNodes")]
        public string TaxonomyNodes { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public enum PageType { Grid, Self };

    public enum ContentResourceType { Paragraph };

    public enum TypeEnum { StorySectionParagraph, StorySectionSubtitle, StorySectionTitle };

    public enum SectionResourceType { Editorial, Product };

    public partial class AlbertHeijn
    {
        public static AlbertHeijn FromJson(string json) => JsonConvert.DeserializeObject<AlbertHeijn>(json, Converter.Settings);
        public static double? GetPrice(AlbertHeijn albertHeijn) => albertHeijn.Embedded.Lanes.FirstOrDefault(f => f.Type == "ProductDetailLane")?.Embedded.Items.FirstOrDefault()?.Embedded.Product.PriceLabel.Now;
    }

    public static class Serialize
    {
        public static string ToJson(this AlbertHeijn self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                PageTypeConverter.Singleton,
                ContentResourceTypeConverter.Singleton,
                TypeEnumConverter.Singleton,
                SectionResourceTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PageTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PageType) || t == typeof(PageType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "grid":
                    return PageType.Grid;
                case "self":
                    return PageType.Self;
            }
            throw new Exception("Cannot unmarshal type PageType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PageType)untypedValue;
            switch (value)
            {
                case PageType.Grid:
                    serializer.Serialize(writer, "grid");
                    return;
                case PageType.Self:
                    serializer.Serialize(writer, "self");
                    return;
            }
            throw new Exception("Cannot marshal type PageType");
        }

        public static readonly PageTypeConverter Singleton = new PageTypeConverter();
    }

    internal class ContentResourceTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ContentResourceType) || t == typeof(ContentResourceType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Paragraph")
            {
                return ContentResourceType.Paragraph;
            }
            throw new Exception("Cannot unmarshal type ContentResourceType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ContentResourceType)untypedValue;
            if (value == ContentResourceType.Paragraph)
            {
                serializer.Serialize(writer, "Paragraph");
                return;
            }
            throw new Exception("Cannot marshal type ContentResourceType");
        }

        public static readonly ContentResourceTypeConverter Singleton = new ContentResourceTypeConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "StorySectionParagraph":
                    return TypeEnum.StorySectionParagraph;
                case "StorySectionSubtitle":
                    return TypeEnum.StorySectionSubtitle;
                case "StorySectionTitle":
                    return TypeEnum.StorySectionTitle;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.StorySectionParagraph:
                    serializer.Serialize(writer, "StorySectionParagraph");
                    return;
                case TypeEnum.StorySectionSubtitle:
                    serializer.Serialize(writer, "StorySectionSubtitle");
                    return;
                case TypeEnum.StorySectionTitle:
                    serializer.Serialize(writer, "StorySectionTitle");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class SectionResourceTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SectionResourceType) || t == typeof(SectionResourceType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Editorial":
                    return SectionResourceType.Editorial;
                case "Product":
                    return SectionResourceType.Product;
            }
            throw new Exception("Cannot unmarshal type SectionResourceType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SectionResourceType)untypedValue;
            switch (value)
            {
                case SectionResourceType.Editorial:
                    serializer.Serialize(writer, "Editorial");
                    return;
                case SectionResourceType.Product:
                    serializer.Serialize(writer, "Product");
                    return;
            }
            throw new Exception("Cannot marshal type SectionResourceType");
        }

        public static readonly SectionResourceTypeConverter Singleton = new SectionResourceTypeConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}

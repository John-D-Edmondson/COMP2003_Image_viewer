
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlazorApp2.Models
{
    public partial class Image
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("evaluatorId")]
        public int EvaluatorId { get; set; }

        [JsonProperty("childAge")]
        public long ChildAge { get; set; }

        [JsonProperty("imgDate")]
        public DateTime ImgDate { get; set; }

        [JsonProperty("imgEvent")]
        public string ImgEvent { get; set; }

        [JsonProperty("evaluator")]
        public object Evaluator { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("ImgGraded")]
        public bool ImgGraded { get; set; }

        [JsonProperty("depth1")]
        public int Depth1 { get; set; }

        [JsonProperty("breadth1")]
        public bool Breadth1 { get; set; }

        [JsonProperty("extent1")]
        public int Extent1 { get; set; }

        [JsonProperty("depth2")]
        public int Depth2 { get; set; }

        [JsonProperty("breadth2")]
        public bool Breadth2 { get; set; }

        [JsonProperty("extent2")]
        public int Extent2 { get; set; }

        [JsonProperty("depth3")]
        public int Depth3 { get; set; }

        [JsonProperty("breadth3")]
        public bool Breadth3 { get; set; }

        [JsonProperty("extent3")]
        public int Extent3 { get; set; }

        [JsonProperty("depth4")]
        public int Depth4 { get; set; }

        [JsonProperty("breadth4")]
        public bool Breadth4 { get; set; }

        [JsonProperty("extent4")]
        public int Extent4 { get; set; }

        [JsonProperty("depth5")]
        public int Depth5 { get; set; }

        [JsonProperty("breadth5")]
        public bool Breadth5 { get; set; }
            
        [JsonProperty("extent5")]
        public int Extent5 { get; set; }

        [JsonProperty("depth6")]
        public int Depth6 { get; set; }

        [JsonProperty("breadth6")]
        public bool Breadth6 { get; set; }

        [JsonProperty("extent6")]
        public int Extent6 { get; set; }

        [JsonProperty("depth7")]
        public int Depth7 { get; set; }

        [JsonProperty("breadth7")]
        public bool Breadth7 { get; set; }

        [JsonProperty("extent7")]
        public int Extent7 { get; set; }

        public bool Deleted { get; set; } = false;


    }

    public partial class Image
    {
        public static Image FromJson(string json) => JsonConvert.DeserializeObject<Image>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Image self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}


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

        [JsonProperty("depth")]
        public int Depth { get; set; }

        [JsonProperty("breadth")]
        public int Breadth { get; set; }

        [JsonProperty("extent")]
        public int Extent { get; set; }

        [JsonProperty("evaluator")]
        public object Evaluator { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("ImgGraded")]
        public bool ImgGraded { get; set; }

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

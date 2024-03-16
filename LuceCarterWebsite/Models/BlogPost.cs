using System.Text.Json.Serialization;
using Contentful.Core.Models;
using Newtonsoft.Json;

namespace LuceCarterWebsite.Models;

    public class Author
    {
        [JsonProperty("sys")]
        [JsonPropertyName("sys")]
        public Sys Sys { get; set; }
    }

    public class Environment
    {
        [JsonProperty("sys")]
        [JsonPropertyName("sys")]
        public Sys Sys { get; set; }
    }

    public class Fields
    {
        [JsonProperty("date")]
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonProperty("author")]
        [JsonPropertyName("author")]
        public Author Author { get; set; }

        [JsonProperty("excerpt")]
        [JsonPropertyName("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("body")]
        [JsonPropertyName("body")]
        public Document Body { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }
    }

    public class BlogPost
    {
        [JsonProperty("metadata")]
        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("sys")]
        [JsonPropertyName("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("fields")]
        [JsonPropertyName("fields")]
        public Fields Fields { get; set; }
    }

    public class Space
    {
        [JsonProperty("sys")]
        [JsonPropertyName("sys")]
        public Sys Sys { get; set; }
    }

    public class Sys
    {
        [JsonProperty("space")]
        [JsonPropertyName("space")]
        public Space Space { get; set; }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("createdAt")]
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("environment")]
        [JsonPropertyName("environment")]
        public Environment Environment { get; set; }

        [JsonProperty("revision")]
        [JsonPropertyName("revision")]
        public int? Revision { get; set; }

        [JsonProperty("contentType")]
        [JsonPropertyName("contentType")]
        public ContentType ContentType { get; set; }

        [JsonProperty("locale")]
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonProperty("linkType")]
        [JsonPropertyName("linkType")]
        public string LinkType { get; set; }
    }

    public class Target
    {
        [JsonProperty("sys")]
        [JsonPropertyName("sys")]
        public Sys Sys { get; set; }
    }


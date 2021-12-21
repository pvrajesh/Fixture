﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Fixture.Models
{
    public class Event
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonPropertyName("payload")]
        public Payload Payload { get; set; }
    }

    public class Market
    {
        [JsonPropertyName("id")]
        public int Id { get; set;}

        [JsonPropertyName("title")]
        public string Title { get; set;}

        [JsonPropertyName("price")]
        public double Price { get; set;}
    }

    public class Sport
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Location
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Timing
    {
        [JsonPropertyName("scheduled_begin")]
        public DateTime ScheduledBegin { get; set; }

        [JsonPropertyName("expected_duration")]
        public string ExpectedDuration { get; set; }
    }

    public class Child
    {
        [JsonPropertyName("competitor_id")]
        public int CompetitorId { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Competitor
    {
        [JsonPropertyName("competitor_id")]
        public int CompetitorId { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("children")]
        public List<Child> Children { get; set; }
    }

    public class Metadata
    {
        [JsonPropertyName("sport")]
        public Sport Sport { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("timing")]
        public Timing Timing { get; set; }

        [JsonPropertyName("competitors")]
        public List<Competitor> Competitors { get; set; }
    }

    public class Payload
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("markets")]
        public List<Market> Markets { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("winners")]
        public List<Winner> Winners { get; internal set; }
    }

    public class Winner
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }


}

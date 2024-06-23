﻿namespace Telegram.Bot.Types;

/// <summary>This object represents a point on the map.</summary>
public partial class Location
{
    /// <summary>Latitude as defined by sender</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public double Latitude { get; set; }

    /// <summary>Longitude as defined by sender</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public double Longitude { get; set; }

    /// <summary><em>Optional</em>. The radius of uncertainty for the location, measured in meters; 0-1500</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? HorizontalAccuracy { get; set; }

    /// <summary><em>Optional</em>. Time relative to the message sending date, during which the location can be updated; in seconds. For active live locations only.</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? LivePeriod { get; set; }

    /// <summary><em>Optional</em>. The direction in which user is moving, in degrees; 1-360. For active live locations only.</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Heading { get; set; }

    /// <summary><em>Optional</em>. The maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? ProximityAlertRadius { get; set; }
}

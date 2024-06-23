﻿namespace Telegram.Bot.Requests;

/// <summary>Use this method to get the current list of the bot's commands for the given scope and user language.<para>Returns: An Array of <see cref="BotCommand"/> objects. If commands aren't set, an empty list is returned.</para></summary>
public partial class GetMyCommandsRequest : RequestBase<BotCommand[]>
{
    /// <summary>An object, describing scope of users. Defaults to <see cref="BotCommandScopeDefault"/>.</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BotCommandScope? Scope { get; set; }

    /// <summary>A two-letter ISO 639-1 language code or an empty string</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? LanguageCode { get; set; }

    /// <summary>Instantiates a new <see cref="GetMyCommandsRequest"/></summary>
    public GetMyCommandsRequest()
        : base("getMyCommands")
    { }
}

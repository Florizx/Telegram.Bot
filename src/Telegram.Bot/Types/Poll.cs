﻿namespace Telegram.Bot.Types;

/// <summary>This object contains information about a poll.</summary>
public partial class Poll
{
    /// <summary>Unique poll identifier</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string Id { get; set; } = default!;

    /// <summary>Poll question, 1-300 characters</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string Question { get; set; } = default!;

    /// <summary><em>Optional</em>. Special entities that appear in the <see cref="Question">Question</see>. Currently, only custom emoji entities are allowed in poll questions</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MessageEntity[]? QuestionEntities { get; set; }

    /// <summary>List of poll options</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public PollOption[] Options { get; set; } = default!;

    /// <summary>Total number of users that voted in the poll</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public int TotalVoterCount { get; set; }

    /// <summary><see langword="true"/>, if the poll is closed</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool IsClosed { get; set; }

    /// <summary><see langword="true"/>, if the poll is anonymous</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool IsAnonymous { get; set; }

    /// <summary>Poll type, currently can be “regular” or “quiz”</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string Type { get; set; } = default!;

    /// <summary><see langword="true"/>, if the poll allows multiple answers</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool AllowsMultipleAnswers { get; set; }

    /// <summary><em>Optional</em>. 0-based identifier of the correct answer option. Available only for polls in the quiz mode, which are closed, or was sent (not forwarded) by the bot or to the private chat with the bot.</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? CorrectOptionId { get; set; }

    /// <summary><em>Optional</em>. Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Explanation { get; set; }

    /// <summary><em>Optional</em>. Special entities like usernames, URLs, bot commands, etc. that appear in the <see cref="Explanation">Explanation</see></summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MessageEntity[]? ExplanationEntities { get; set; }

    /// <summary><em>Optional</em>. Amount of time in seconds the poll will be active after creation</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? OpenPeriod { get; set; }

    /// <summary><em>Optional</em>. Point in time when the poll will be automatically closed</summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? CloseDate { get; set; }
}

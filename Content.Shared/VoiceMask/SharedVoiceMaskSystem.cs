using Robust.Shared.Serialization;

namespace Content.Shared.VoiceMask;

[Serializable, NetSerializable]
public enum VoiceMaskUIKey : byte
{
    Key
}

[Serializable, NetSerializable]
public sealed class VoiceMaskBuiState : BoundUserInterfaceState
{
    public readonly string Name;
    public readonly string? Verb;
<<<<<<< HEAD
    public readonly string Voice; // Corvax-TTS
    public readonly string Bark; // ADT Barks
    public readonly float Pitch; // ADT Barks
    public VoiceMaskBuiState(string name, string voice, string bark, float pitch, string? verb)
    // public VoiceMaskBuiState(string name, string voice, string? verb)
    {
        Name = name;
        Verb = verb;
        Voice = voice;  // Corvax-TTS
        Bark = bark; // ADT Barks
        Pitch = pitch; // ADT Barks
=======
    public readonly bool Active;
    public readonly bool AccentHide;

    public VoiceMaskBuiState(string name, string? verb, bool active, bool accentHide)
    {
        Name = name;
        Verb = verb;
        Active = active;
        AccentHide = accentHide;
>>>>>>> upstreamcorv
    }
}

[Serializable, NetSerializable]
public sealed class VoiceMaskChangeNameMessage : BoundUserInterfaceMessage
{
    public readonly string Name;

    public VoiceMaskChangeNameMessage(string name)
    {
        Name = name;
    }
}

/// <summary>
/// Change the speech verb prototype to override, or null to use the user's verb.
/// </summary>
[Serializable, NetSerializable]
public sealed class VoiceMaskChangeVerbMessage : BoundUserInterfaceMessage
{
    public readonly string? Verb;

    public VoiceMaskChangeVerbMessage(string? verb)
    {
        Verb = verb;
    }
}

/// <summary>
///     Toggle the effects of the voice mask.
/// </summary>
[Serializable, NetSerializable]
public sealed class VoiceMaskToggleMessage : BoundUserInterfaceMessage;

/// <summary>
///     Toggle the effects of accent negation.
/// </summary>
[Serializable, NetSerializable]
public sealed class VoiceMaskAccentToggleMessage : BoundUserInterfaceMessage;

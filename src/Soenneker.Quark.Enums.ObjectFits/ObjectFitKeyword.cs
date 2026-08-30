using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a CSS <c>object-fit</c> keyword.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class ObjectFitKeyword
{
    /// <summary>
    /// Scales the object to fit inside its box while preserving its aspect ratio.
    /// </summary>
    public static readonly ObjectFitKeyword Contain = new("contain");
    /// <summary>
    /// Scales the object to cover its box while preserving its aspect ratio.
    /// </summary>
    public static readonly ObjectFitKeyword Cover = new("cover");
    /// <summary>
    /// Stretches the object to fill its box.
    /// </summary>
    public static readonly ObjectFitKeyword Fill = new("fill");
    /// <summary>
    /// Selects whichever of <c>none</c> and <c>contain</c> produces the smaller object.
    /// </summary>
    public static readonly ObjectFitKeyword ScaleDown = new("scale-down");
    /// <summary>
    /// Does not resize the object.
    /// </summary>
    public static readonly ObjectFitKeyword None = new("none");
}

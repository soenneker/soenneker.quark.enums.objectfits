using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Typed values for the CSS object-fit property in .NET enumeration form.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class ObjectFitKeyword
{
    /// <summary>
    /// The contain.
    /// </summary>
    public static readonly ObjectFitKeyword Contain = new("contain");
    /// <summary>
    /// The cover.
    /// </summary>
    public static readonly ObjectFitKeyword Cover = new("cover");
    /// <summary>
    /// The fill.
    /// </summary>
    public static readonly ObjectFitKeyword Fill = new("fill");
    /// <summary>
    /// The scale down.
    /// </summary>
    public static readonly ObjectFitKeyword ScaleDown = new("scale-down");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly ObjectFitKeyword None = new("none");
}

using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Typed values for the CSS object-fit property in .NET enumeration form.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class ObjectFitKeyword
{
    public static readonly ObjectFitKeyword Contain = new("contain");
    public static readonly ObjectFitKeyword Cover = new("cover");
    public static readonly ObjectFitKeyword Fill = new("fill");
    public static readonly ObjectFitKeyword ScaleDown = new("scale-down");
    public static readonly ObjectFitKeyword None = new("none");
}

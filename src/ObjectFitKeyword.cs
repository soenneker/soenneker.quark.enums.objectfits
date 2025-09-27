using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Typed values for the CSS object-fit property in .NET enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class ObjectFitKeywordKeyword
{
    public static readonly ObjectFitKeyword Contain = new("contain");
    public static readonly ObjectFitKeyword Cover = new("cover");
    public static readonly ObjectFitKeyword Fill = new("fill");
    public static readonly ObjectFitKeyword ScaleDown = new("scale-down");
    public static readonly ObjectFitKeyword None = new("none");

    public static implicit operator ObjectFitKeyword(GlobalKeyword style) => new(style.Value);
}

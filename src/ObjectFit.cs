using Intellenum;
using Soenneker.Quark.Enums.GlobalKeywords;

namespace Soenneker.Quark.Enums.ObjectFits;

/// <summary>
/// Typed values for the CSS object-fit property in .NET enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class ObjectFit
{
    public static readonly ObjectFit Contain = new("contain");
    public static readonly ObjectFit Cover = new("cover");
    public static readonly ObjectFit Fill = new("fill");
    public static readonly ObjectFit ScaleDown = new("scale-down");
    public static readonly ObjectFit None = new("none");

    public static implicit operator ObjectFit(GlobalKeyword style) => new(style.Value);
}

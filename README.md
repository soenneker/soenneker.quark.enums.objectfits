[![](https://img.shields.io/nuget/v/soenneker.quark.enums.objectfits.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.objectfits/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.objectfits/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.objectfits/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.objectfits/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.objectfits/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.objectfits.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.objectfits/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.objectfits/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.objectfits/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.ObjectFits

Strongly typed CSS `object-fit` values for Quark media components and styles.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.ObjectFits
```

## Usage

```csharp
ObjectFitKeyword fit = ObjectFitKeyword.Cover;
string cssValue = fit.Value; // "cover"
```

`Cover` is useful for filling a fixed media box and allowing cropping; `Contain` preserves the whole object and may leave empty space. The type also includes CSS-wide values from `GlobalKeyword`.

## Values

| Member | CSS value | Behavior |
| --- | --- | --- |
| `Contain` | `contain` | Preserves aspect ratio and fits the entire object inside the box. |
| `Cover` | `cover` | Preserves aspect ratio and fills the box, cropping if necessary. |
| `Fill` | `fill` | Stretches the object to fill the box. |
| `ScaleDown` | `scale-down` | Uses whichever of `none` or `contain` produces the smaller object. |
| `None` | `none` | Does not resize the object. |

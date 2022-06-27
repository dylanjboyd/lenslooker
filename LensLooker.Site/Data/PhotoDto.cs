namespace LensLooker.Site.Data;

public record PhotoDto(
    string Src,
    string ViewingUrl,
    string OwnerId,
    string? Title = default,
    string? Camera = default,
    string? Lens = default,
    int? FocalLength = default,
    double? Aperture = default,
    string? ShutterSpeed = default
);
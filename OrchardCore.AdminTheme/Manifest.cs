using OrchardCore.DisplayManagement.Manifest;

[assembly: Theme(
    Name = "OrchardCore.AdminTheme",
    Author = "Pawel Nowak",
    Website = "https://dont-know-yet.net",
    Version = "0.0.1",
    Description = "Extended TheAdmin theme",
    Tags = new[] { "admin" },
    BaseTheme = "TheAdmin",
    Dependencies =
    [
        "OrchardCore.Themes",
        "OrchardCore.Admin",
        "OrchardCore.Users"
    ]
)]

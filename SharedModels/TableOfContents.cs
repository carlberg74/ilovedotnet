﻿namespace SharedModels;

public class TableOfContents
{
    public List<ContentMetaData> Contents { get; set; } =
        new(11)
        {
            new ContentMetaData
            {
                Title = "Blazor WASM Exception Handling and Error Boundary",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/blazor/wasm/blazor-wasm-exception-handling-and-error-boundary.svg",
                ThumbnailUrl = "image/blogs/blazor/wasm/blazor-wasm-exception-handling-and-error-boundary.svg",
                ContentUrl = "blogs/blazor-wasm-exception-handling-and-error-boundary",
                IconUrl = "image/icons/blazor.png",
                Type = "Blazor",
                CreatedOn = new DateTime(2022, 1, 16, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 1, 23, 22, 30, 0)
            },
            new ContentMetaData
            {
                Title = "Blazor WASM Error Logging",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/blazor/wasm/blazor-wasm-error-logging.svg",
                ThumbnailUrl = "image/blogs/blazor/wasm/blazor-wasm-error-logging.svg",
                ContentUrl = "blogs/blazor-wasm-error-logging",
                IconUrl = "image/icons/blazor.png",
                Type = "Blazor",
                CreatedOn = new DateTime(2022, 1, 23, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 1, 23, 22, 30, 0)
            },
            new ContentMetaData
            {
                Title = "Blazor WASM Dark Theme and Light Theme",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/blazor/wasm/blazor-wasm-dark-theme-and-light-theme.svg",
                ThumbnailUrl = "image/blogs/blazor/wasm/blazor-wasm-dark-theme-and-light-theme.svg",
                ContentUrl = "blogs/blazor-wasm-dark-theme-and-light-theme",
                IconUrl = "image/icons/blazor.png",
                Type = "Blazor",
                CreatedOn = new DateTime(2022, 1, 30, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 1, 30, 22, 30, 0)
            },
            new ContentMetaData
            {
                Title = "Blazor WASM Javascript Interop and Isolation",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/blazor/wasm/blazor-wasm-javascript-interop-and-isolation.svg",
                ThumbnailUrl = "image/blogs/blazor/wasm/blazor-wasm-javascript-interop-and-isolation.svg",
                ContentUrl = "blogs/blazor-wasm-javascript-interop-and-isolation",
                IconUrl = "image/icons/blazor.png",
                Type = "Blazor",
                CreatedOn = new DateTime(2022, 2, 6, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 2, 6, 22, 30, 0)
            },
            new ContentMetaData
            {
                Title = "Blazor WASM Styles and CSS Isolation",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/blazor/wasm/blazor-wasm-styles-and-css-isolation.svg",
                ThumbnailUrl = "image/blogs/blazor/wasm/blazor-wasm-styles-and-css-isolation.svg",
                ContentUrl = "blogs/blazor-wasm-styles-and-css-isolation",
                IconUrl = "image/icons/blazor.png",
                Type = "Blazor",
                CreatedOn = new DateTime(2022, 2, 13, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 2, 20, 22, 30, 0)
            },
            new ContentMetaData
            {
                Title = "Blazor WASM Lazy Loading",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/blazor/wasm/blazor-wasm-lazy-loading.svg",
                ThumbnailUrl = "image/blogs/blazor/wasm/blazor-wasm-lazy-loading.svg",
                ContentUrl = "blogs/blazor-wasm-lazy-loading",
                IconUrl = "image/icons/blazor.png",
                Type = "Blazor",
                CreatedOn = new DateTime(2022, 2, 20, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 2, 20, 22, 30, 0)
            },
            new ContentMetaData
            {
                Title = "Blazor WASM App Settings",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/blazor/wasm/blazor-wasm-app-settings.svg",
                ThumbnailUrl = "image/blogs/blazor/wasm/blazor-wasm-app-settings.svg",
                ContentUrl = "blogs/blazor-wasm-app-settings",
                IconUrl = "image/icons/blazor.png",
                Type = "Blazor",
                CreatedOn = new DateTime(2022, 2, 27, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 2, 27, 22, 30, 0)
            },
            new ContentMetaData
            {
                Title = "Importance of Status Code in Web API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/webapi-importance-of-status-code.svg",
                ThumbnailUrl = "image/blogs/webapi/webapi-importance-of-status-code.svg",
                ContentUrl = "blogs/webapi-importance-of-status-code",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2022, 3, 6, 22, 30, 0)
            },
            new ContentMetaData
            {
                Title = "Blazor - SPA from ASP.NET Family",
                Author = "Abdul Rahman",
                PosterUrl = "image/talks/blazor-spa-from-aspnet-family.svg",
                ThumbnailUrl = "image/talks/blazor-spa-from-aspnet-family.svg",
                ContentUrl = "talks/blazor-spa-from-aspnet-family",
                IconUrl = "image/icons/talk.png",
                Type = "Talk",
                CreatedOn = new DateTime(2022, 3, 13, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 3, 13, 22, 30, 0)
            },
            new ContentMetaData
            {
                Title = "Blazor WASM Introduction",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/blazor/wasm/blazor-wasm-introduction.svg",
                ThumbnailUrl = "image/blogs/blazor/wasm/blazor-wasm-introduction.svg",
                ContentUrl = "blogs/blazor-wasm-introduction",
                IconUrl = "image/icons/blazor.png",
                Type = "Blazor",
                CreatedOn = new DateTime(2022, 3, 20, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 3, 20, 22, 30, 0)
            },
            new ContentMetaData
            {
                Title = "Introducing TDD in C# .Net",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/tdd/introducing-tdd-in-csharp-dotnet.svg",
                ThumbnailUrl = "image/blogs/tdd/introducing-tdd-in-csharp-dotnet.svg",
                ContentUrl = "blogs/introducing-tdd-in-csharp-dotnet",
                IconUrl = "image/icons/tdd.png",
                Type = "TDD",
                CreatedOn = new DateTime(2022, 3, 27, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 3, 27, 22, 30, 0)
            }
        };
}
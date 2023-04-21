﻿namespace SharedModels;

public class SOLIDLearningPath
{
    public readonly List<ContentMetaData> FullContents = new(3);

    public SOLIDLearningPath()
    {
        FullContents =
        new(3)
        {
            new ContentMetaData
            {
                Order = 1,
                Title = "SOLID Principles Introduction",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/solid/solid-principles-introduction.svg",
                ThumbnailUrl = "image/blogs/solid/solid-principles-introduction.svg",
                ContentUrl = "blogs/solid-principles-introduction",
                IconUrl = "image/icons/solid.png",
                Type = "SOLID",
                CreatedOn = new DateTime(2023, 4, 2, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 4, 2, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 2,
                Title = "Single Responsibility Principle in SOLID",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/solid/single-responsibility-principle-in-solid.svg",
                ThumbnailUrl = "image/blogs/solid/single-responsibility-principle-in-solid.svg",
                ContentUrl = "blogs/single-responsibility-principle-in-solid",
                IconUrl = "image/icons/solid.png",
                Type = "SOLID",
                CreatedOn = new DateTime(2023, 4, 16, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 4, 16, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 3,
                Title = "Open Closed Principle in SOLID",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/solid/open-closed-principle-in-solid.svg",
                ThumbnailUrl = "image/blogs/solid/open-closed-principle-in-solid.svg",
                ContentUrl = "blogs/open-closed-principle-in-solid",
                IconUrl = "image/icons/solid.png",
                Type = "SOLID",
                CreatedOn = new DateTime(2023, 4, 23, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 4, 23, 22, 30, 0)
            },
        };
    }
}

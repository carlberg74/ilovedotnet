﻿namespace SharedModels;

public class WebAPILearningPath 
{
    public readonly List<ContentMetaData> FullContents = new(2);

    public WebAPILearningPath()
    {
        FullContents =
        new(2)
        {
            new ContentMetaData
            {
                Order = 1,
                Title = "Importance of Status Code in Web API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/webapi-importance-of-status-code.svg",
                ThumbnailUrl = "image/blogs/webapi/webapi-importance-of-status-code.svg",
                ContentUrl = "blogs/webapi-importance-of-status-code",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2022, 3, 6, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 3, 6, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 2,
                Title = "Profiling Web API with Mini Profiler",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/profiling-webapi-with-mini-profiler.svg",
                ThumbnailUrl = "image/blogs/webapi/profiling-webapi-with-mini-profiler.svg",
                ContentUrl = "blogs/profiling-webapi-with-mini-profiler",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2022, 9, 18, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 9, 18, 22, 30, 0)
            }
        };
    }
}
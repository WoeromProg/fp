﻿using TagsCloudContainer.WordProcessing;

namespace TagsCloudContainer.App;

public interface IApp
{
    public Result<None> Run();
}
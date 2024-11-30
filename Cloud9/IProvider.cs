﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Cloud9
{
    public interface IProvider
    {
        Dictionary<string, Uri> Endpoints { get; }
        Uri Url { get; }
        bool Working { get; }
        bool SupportsSystemMessages { get; }
        bool SupportsMessageHistory { get; }

        void FetchCompletionModels();
        void FetchImagineModels();

        string DefaultModel { get; }
        string DefaultImageModel { get; }
        List<string> AdditionalImageModels { get; }

        void GetModels();

        Dictionary<string, string> ModelAliases { get; }

        void GenerateText(object cls, string model, List<string> messages, string? proxy = null, int? seed = null, string? size = "1:1");
        void GenerateImage(object cls, string model, List<string> messages, string? proxy = null, int? seed = null, string? size = "1:1");
        string FilterContent(object cls, string partResponse);
    }
}
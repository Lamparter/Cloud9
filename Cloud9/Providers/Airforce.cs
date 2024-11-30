using System;
using System.Collections.Generic;
using Riverside.Extensions;
using System.Threading.Tasks;

namespace Riverside.Cloud9.Providers
{
    public class Airforce : IProvider
    {
        public Uri Url => new("https://llmplayground.net");
        public Dictionary<string, Uri> Endpoints => new()
        {
            { "api_endpoint_completions", new Uri("https://api.airforce/chat/completions") },
            { "api_endpoint_imagine", new Uri("https://api.airforce/chat/completions") }
        };
        public bool Working => true;
        public bool SupportsSystemMessages => true;
        public bool SupportsMessageHistory => true;

        public async Task<string> FetchCompletionModels() => await Http.FetchDataAsync("https://api.airforce/models");
        public async Task<string> FetchImagineModels() => await Http.FetchDataAsync("https://api.airforce/imagine/models");

        public string DefaultModel => "gpt-4o-mini";
        public string DefaultImageModel => "flux";
        public List<string> AdditionalImageModels => ["stable-diffusion-xl-base", "stable-diffusion-xl-lightning", "flux-1.1-pro"];

        public Dictionary<string, string> ModelAliases
        {

        }
    }
}

using System.Text.Json.Serialization;
using WebApplication1.Controllers;

namespace WebApplication1
{
    [JsonSerializable(typeof(DtoIn))]
    [JsonSerializable(typeof(DtoOut))]
    [JsonSourceGenerationOptions(
    WriteIndented = true,
    GenerationMode = JsonSourceGenerationMode.Default,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase
    )]
    internal partial class SourceGenerator : JsonSerializerContext
    {
    }
}

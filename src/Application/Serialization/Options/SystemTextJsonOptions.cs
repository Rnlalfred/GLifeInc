using System.Text.Json;
using GLifeInc.Application.Interfaces.Serialization.Options;

namespace GLifeInc.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}
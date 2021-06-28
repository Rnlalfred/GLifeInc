
using GLifeInc.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace GLifeInc.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}
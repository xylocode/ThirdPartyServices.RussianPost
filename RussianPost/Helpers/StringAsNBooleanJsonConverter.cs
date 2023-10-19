using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.Helpers
{
    internal class StringAsNBooleanJsonConverter : JsonConverter<bool?>
    {
        public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            if (string.IsNullOrWhiteSpace(s))
                return false;

            if (bool.TryParse(s, out bool result))
                return result;

            return s switch
            {
                "0" => false,
                "1" => true,
                _ => null,
            };
        }

        public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteBooleanValue(value.Value);
        }
    }
}

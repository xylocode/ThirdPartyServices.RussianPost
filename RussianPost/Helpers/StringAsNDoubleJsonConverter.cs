using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.Helpers
{
    internal class StringAsNDoubleJsonConverter : JsonConverter<double?>
    {
        public override double? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            var styles = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            if (double.TryParse(s, styles, CultureInfo.InvariantCulture, out double result))
                return result;
            return null;
        }

        public override void Write(Utf8JsonWriter writer, double? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
        }
    }
}

﻿using System;
using Newtonsoft.Json;
using System.IO;

namespace FindJob.Services
{
    public class StreamStringConverter : JsonConverter
    {
        private static Type AllowedType = typeof(Stream);

        public override bool CanConvert(Type objectType)
            => objectType == AllowedType;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var objectContents = (string)reader.Value;
            var base64Decoded = Convert.FromBase64String(objectContents);

            var memoryStream = new MemoryStream(base64Decoded);

            return memoryStream;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var valueStream = (FileStream)value;
            var fileBytes = new byte[valueStream.Length];

            valueStream.Read(fileBytes, 0, (int)valueStream.Length);

            var bytesAsString = Convert.ToBase64String(fileBytes);

            writer.WriteValue(bytesAsString);
        }
    }
}


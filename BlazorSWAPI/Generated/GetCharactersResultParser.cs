using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace BlazorSWAPI
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetCharactersResultParser
        : JsonResultParserBase<IGetCharacters>
    {
        private readonly IValueSerializer _stringSerializer;
        private readonly IValueSerializer _floatSerializer;

        public GetCharactersResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _stringSerializer = serializerResolver.Get("String");
            _floatSerializer = serializerResolver.Get("Float");
        }

        protected override IGetCharacters ParserData(JsonElement data)
        {
            return new GetCharacters
            (
                ParseGetCharactersCharacters(data, "characters")
            );

        }

        private global::BlazorSWAPI.ICharacterConnection ParseGetCharactersCharacters(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return new CharacterConnection
            (
                ParseGetCharactersCharactersNodes(obj, "nodes")
            );
        }

        private global::System.Collections.Generic.IReadOnlyList<global::BlazorSWAPI.ICharacter> ParseGetCharactersCharactersNodes(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            int objLength = obj.GetArrayLength();
            var list = new global::BlazorSWAPI.ICharacter[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new Character
                (
                    DeserializeString(element, "name"),
                    DeserializeFloat(element, "height")
                );

            }

            return list;
        }

        private string DeserializeString(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (string)_stringSerializer.Deserialize(value.GetString());
        }

        private double DeserializeFloat(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (double)_floatSerializer.Deserialize(value.GetDouble());
        }
    }
}

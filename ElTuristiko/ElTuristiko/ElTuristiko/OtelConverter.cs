using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//kaynak : https://blog.codeinside.eu/2015/03/30/json-dotnet-deserialize-to-abstract-class-or-interface/
//abstract sınıflar jsondan okunurken hata veriyordu hata çözümü yukarıdaki linkte mevcur
namespace ElTuristiko
{
    class OtelConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Otel));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            if (jo["Tur"].Value<string>() == "Pansiyon")
                return jo.ToObject<Pansiyon>(serializer);
            if (jo["Tur"].Value<string>() == "Butik Otel")
                return jo.ToObject<ButikOtel>(serializer);
            if (jo["Tur"].Value<string>() == "Tatil Köyü")
                return jo.ToObject<TatilKoyu>(serializer);
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}

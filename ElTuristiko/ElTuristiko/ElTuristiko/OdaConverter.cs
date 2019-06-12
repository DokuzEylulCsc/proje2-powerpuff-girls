using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTuristiko
{
    class OdaConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Oda));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo;
            try
            {
                jo = JObject.Load(reader);

            }
            catch (Exception)
            {

                return null;
            }
            if (jo["Tip"].Value<int>() == 1)
                return jo.ToObject<TekKisilik>(serializer);
            if (jo["Tip"].Value<int>() == 2)
                return jo.ToObject<CiftKisilik>(serializer);
            if (jo["Tip"].Value<int>() == 3)
                return jo.ToObject<DortKisilik>(serializer);
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}

using Newtonsoft.Json;

namespace Store.Utils.Extension
{
    public static class JsonExtensions
    {
        public static T Deserialize<T>(this string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return default;
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string Serialize(this object obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }

            return JsonConvert.SerializeObject(obj);
        }
    }
}

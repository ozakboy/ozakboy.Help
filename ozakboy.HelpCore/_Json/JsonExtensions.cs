using System.Text.Json;

namespace ozakboy.HelpCore
{
    public static class JsonExtensions
    {
        /// <summary>
        /// 將物件序列化為JSON字符串
        /// </summary>
        /// <param name="obj">要序列化的物件</param>
        /// <returns>JSON字符串</returns>
        public static string ToJsonString(this object obj)
        {
            return JsonSerializer.Serialize(obj);
        }

        /// <summary>
        /// 將JSON字符串反序列化為指定的類型
        /// </summary>
        /// <typeparam name="T">要反序列化的類型</typeparam>
        /// <param name="json">要反序列化的JSON字符串</param>
        /// <returns>反序列化後的對象</returns>
        public static T FromJsonString<T>(this string json)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}

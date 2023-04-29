using System.ComponentModel;


namespace ozakboy.Help
{
    public static  class EnumExtensions
    {
        /// <summary>
        /// 從枚舉常數中獲取描述文本
        /// </summary>
        /// <param name="value">要獲取描述文本的枚舉常數</param>
        /// <returns>枚舉常數的描述文本</returns>
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var descriptionAttribute =
              (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute), false);


            return descriptionAttribute?.Description ?? value.ToString();
        }
    }
}

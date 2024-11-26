using System;
using System.Runtime.Serialization;

namespace ozakboy.Help
{
    /// <summary>
    /// 自定義錯誤訊息異常類，用於處理和傳遞應用程序中的錯誤訊息
    /// </summary>
    [Serializable]
    public class ErrorMessageException : Exception
    {
        /// <summary>
        /// 錯誤代碼
        /// </summary>
        public string ErrorCode { get; }

        /// <summary>
        /// 額外的錯誤資訊
        /// </summary>
        public object? AdditionalInfo { get; }

        /// <summary>
        /// 初始化 ErrorMessageException 的新實例，使用預設錯誤訊息
        /// </summary>
        public ErrorMessageException()
            : base("An error occurred in the application")
        {
            ErrorCode = "DEFAULT_ERROR";
            HelpLink = "MyServerError";
        }

        /// <summary>
        /// 初始化 ErrorMessageException 的新實例，使用指定的錯誤訊息
        /// </summary>
        /// <param name="message">描述錯誤的訊息</param>
        public ErrorMessageException(string message)
            : base(message)
        {
            ErrorCode = "CUSTOM_ERROR";
            HelpLink = "MyServerError";
        }

        /// <summary>
        /// 初始化 ErrorMessageException 的新實例，使用指定的錯誤訊息和錯誤代碼
        /// </summary>
        /// <param name="message">描述錯誤的訊息</param>
        /// <param name="errorCode">錯誤代碼</param>
        public ErrorMessageException(string message, string errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
            HelpLink = "MyServerError";
        }

        /// <summary>
        /// 初始化 ErrorMessageException 的新實例，使用指定的錯誤訊息、錯誤代碼和額外資訊
        /// </summary>
        /// <param name="message">描述錯誤的訊息</param>
        /// <param name="errorCode">錯誤代碼</param>
        /// <param name="additionalInfo">額外的錯誤相關資訊</param>
        public ErrorMessageException(string message, string errorCode, object? additionalInfo)
            : base(message)
        {
            ErrorCode = errorCode;
            AdditionalInfo = additionalInfo;
            HelpLink = "MyServerError";
        }

        /// <summary>
        /// 初始化 ErrorMessageException 的新實例，使用指定的錯誤訊息和內部異常
        /// </summary>
        /// <param name="message">描述錯誤的訊息</param>
        /// <param name="innerException">導致當前異常的異常</param>
        public ErrorMessageException(string message, Exception innerException)
            : base(message, innerException)
        {
            ErrorCode = "INNER_ERROR";
            HelpLink = "MyServerError";
        }

        /// <summary>
        /// 初始化 ErrorMessageException 的新實例，用於序列化
        /// </summary>
        /// <param name="info">序列化數據</param>
        /// <param name="context">序列化的上下文流</param>
        protected ErrorMessageException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            ErrorCode = info.GetString(nameof(ErrorCode)) ?? "UNKNOWN_ERROR";
            AdditionalInfo = info.GetValue(nameof(AdditionalInfo), typeof(object));
            HelpLink = "MyServerError";
        }

        /// <summary>
        /// 設置序列化數據
        /// </summary>
        /// <param name="info">序列化數據</param>
        /// <param name="context">序列化的上下文流</param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(ErrorCode), ErrorCode);
            info.AddValue(nameof(AdditionalInfo), AdditionalInfo);
        }

        /// <summary>
        /// 獲取異常的詳細字符串表示
        /// </summary>
        /// <returns>包含異常詳細信息的字符串</returns>
        public override string ToString()
        {
            var result = $"ErrorCode: {ErrorCode}\nMessage: {Message}";
            if (AdditionalInfo != null)
            {
                result += $"\nAdditional Info: {AdditionalInfo}";
            }
            if (InnerException != null)
            {
                result += $"\nInner Exception: {InnerException}";
            }
            return result;
        }
    }
}
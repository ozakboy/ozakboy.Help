# ozakboy.Help

[![nuget](https://img.shields.io/badge/nuget-ozakboy.Help-blue)](https://www.nuget.org/packages/ozakboy.Help/) [![github](https://img.shields.io/badge/github-ozakboy.Help-blue)](https://github.com/ozakboy/ozakboy.Help)

## 專案簡介

ozakboy.Help 是一個實用的 .NET 擴展函式庫，旨在簡化開發過程中常用的程式碼操作。本套件封裝了多個常用的擴展方法，讓開發過程更加流暢和高效。

## 支援框架

- .NET Core 3.1
- .NET 6.0
- .NET 7.0

## 安裝方式

使用 NuGet Package Manager:

```bash
Install-Package ozakboy.Help
```

或使用 .NET CLI:

```bash
dotnet add package ozakboy.Help
```

## 功能特色

### 1. 日期時間處理 (DatetimeToTimestampHelp)
- `ToUnixTimestamp`: 將 UTC DateTime 轉換為 Unix 時間戳
- `FromUnixTimestamp`: 將 Unix 時間戳轉換為 UTC DateTime
- `DefulteData`: 取得預設時間 (2000/1/1)

### 2. 列舉擴展 (EnumExtensions)
- `GetDescription`: 從列舉常數中獲取描述文字，支援 DescriptionAttribute

### 3. JSON 處理 (JsonExtensions)
- `ToJsonString`: 將物件序列化為 JSON 字串
- `FromJsonString<T>`: 將 JSON 字串反序列化為指定的類型

### 4. 異常處理 (ErrorMessageException)
自定義的異常處理類，提供：
- 錯誤代碼支援
- 額外資訊儲存
- 完整的序列化支援
- 豐富的建構函式選項

## 使用範例

### 日期時間轉換
```csharp
// DateTime 轉 Unix 時間戳
DateTime utcNow = DateTime.UtcNow;
long timestamp = utcNow.ToUnixTimestamp();

// Unix 時間戳轉 DateTime
DateTime dateTime = DatetimeToTimestampHelp.FromUnixTimestamp(timestamp);
```

### 列舉描述獲取
```csharp
public enum Status
{
    [Description("處理中")]
    Processing,
    [Description("已完成")]
    Completed
}

Status status = Status.Processing;
string description = status.GetDescription(); // 返回 "處理中"
```

### JSON 序列化
```csharp
var obj = new { Name = "測試", Value = 123 };
string json = obj.ToJsonString();

var deserializedObj = json.FromJsonString<dynamic>();
```

### 異常處理
```csharp
try
{
    throw new ErrorMessageException("發生錯誤", "ERR001", new { Details = "額外資訊" });
}
catch (ErrorMessageException ex)
{
    Console.WriteLine(ex.ErrorCode);    // ERR001
    Console.WriteLine(ex.Message);      // 發生錯誤
    Console.WriteLine(ex.AdditionalInfo); // { Details = "額外資訊" }
}
```

## 貢獻指南

歡迎提交 Issue 和 Pull Request 來協助改進這個專案。

## 維護資訊

- 持續維護中
- 定期更新
- 歡迎回報問題

## 相關連結

- [NuGet 套件頁面](https://www.nuget.org/packages/ozakboy.Help/)
- [GitHub 儲存庫](https://github.com/ozakboy/ozakboy.Help)
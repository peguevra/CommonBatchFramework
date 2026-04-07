# CommonBatchFramework

Lightweight batch framework for .NET
Minimal, rule-based structure for consistent batch processing.

This repository includes a sample project (**MyProject**) demonstrating usage.

---

## NuGet

CommonBatchFramework is available on NuGet:

https://www.nuget.org/packages/CommonBatchFramework

Install via CLI:

```bash
dotnet add package CommonBatchFramework
```

---

## Quick Start

```csharp
using CommonBatchFramework.App;

AppRunner.Run(() =>
{
    var paths = new GlobalPaths();
    paths.EnsureDirectories();

    Log.Initialize(paths.OutputDir);

    Log.Info("処理開始");

    // 任意の処理

    Log.Info("処理完了");
});
```

---

## 概要

CommonBatchFramework は、C# バッチ処理における共通ルールを提供する軽量フレームワークです。

多機能なライブラリとは異なり、プロジェクトに共通して必要となるコア機能とルールのみを提供します。

---

## 設計哲学

### コアに徹する

* 開始／終了ログの共通化
* Enter待ちによる終了制御
* 共通パス管理（GlobalPaths）
* ログ出力ルールの統一

### 不要な拡張は持たない

* 過剰な機能や外部依存は持たない
* 必要な拡張は各プロジェクト側で実装する

### ルールを共通化

* 「機能」ではなく「書き方」を統一する
* パス管理、出力管理、例外処理、ログ出力の標準化

### 単一 exe にも対応

* 開発時は bin/Debug/net8.0/ を基準
* 公開 exe は publish/ フォルダ基準
* AppContext.BaseDirectory を基準とした絶対パス運用

---

## 特徴

* Output ディレクトリは常に存在し、なければ自動生成される
* GlobalPaths.cs にパスを集約し、他クラスは参照のみ行う
* 開発時・単一 exe 運用時で同一コードを利用可能
* バッチ処理の開始・終了・例外処理を統一
* ログ出力フォーマットと出力先を統一

---

## ログルール

本フレームワークでは、ログを「機能」としてではなく「ルール」として扱います。

### 基本方針

* Log クラスを通して出力する
* フォーマットを統一する
* 出力先は Console と Output/log.txt に固定する
* ログレベルは最小限（Info / Error）のみとする

### 出力形式

```
[yyyy-MM-dd HH:mm:ss] メッセージ
[yyyy-MM-dd HH:mm:ss] ERROR: メッセージ
```

### 初期化

```csharp
Log.Initialize(paths.OutputDir);
```

### 使用例

```csharp
Log.Info("処理開始");
Log.Error("エラーが発生しました");
```

---

## 利用方法

### 1. NuGet から追加

```bash
dotnet add package CommonBatchFramework
```

---

### 2. 基本構成

```csharp
using CommonBatchFramework.App;

AppRunner.Run(() =>
{
    var paths = new GlobalPaths();
    paths.EnsureDirectories();

    Log.Initialize(paths.OutputDir);

    var service = new SampleService();
    service.Execute(paths);
});
```

---

### 3. パス利用

```csharp
Console.WriteLine($"InputDir: {paths.InputDir}");
Console.WriteLine($"OutputDir: {paths.OutputDir}");
```

---

### 4. ログ利用

```csharp
Log.Info("処理開始");

// 任意の処理

Log.Info("処理完了");
```

---

## Example Project Structure

```
MyProject/
 ├─ Input/
 ├─ Output/
 │   └─ log.txt
 ├─ src/
 │   ├─ GlobalPaths.cs
 │   └─ Services/
 │       └─ SampleService.cs
 └─ Program.cs
```

### ディレクトリ説明

* Input
  入力ファイルを配置するディレクトリ

* Output
  出力ファイルおよびログ（log.txt）が生成されるディレクトリ

* src
  アプリケーションコードを配置する

* Program.cs
  エントリポイント（AppRunner により実行）

---

## 想定される利用シーン

* 複数のバッチプロジェクトで共通の実行構造を統一する
* Input / Output フォルダを共通ルールで管理する
* ログ出力形式を統一し、運用時の確認を容易にする
* 小規模〜中規模のバッチ処理の基盤として利用する

---

## 構成方針

* AppRunner により実行フローを統一
* GlobalPaths によりパス管理を集中
* Log により出力ルールを統一

各要素は独立しており、プロジェクト側で必要に応じた拡張が可能です。

---

## Sample Project

This repository includes a sample implementation:

* MyProject

Refer to it for a complete working example.

---

## 補足

* 本フレームワークは追加機能の提供を目的としません
* 共通ルールの提供と、それに基づく構造の統一を目的とします

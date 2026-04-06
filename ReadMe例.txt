CommonBatchFramework
概要

CommonBatchFramework は、すべての C# バッチ処理プロジェクトで共通して利用できる、軽量・最小限のフレームワークです。

多機能で煌びやかな既存ライブラリとは異なり、プロジェクトに必ず必要なコア機能とルールのみを提供します。

設計哲学
コアに徹する
開始／終了ログの共通表示
Enter 待ちで終了
共通パス管理（GlobalPaths）
不要な拡張は持たない
大規模ライブラリのような過剰な機能は排除
開発者が必要なものだけ追加できる構造
ルールを共通化
「機能」ではなく「ルール」を共通化
パス管理、出力管理、例外処理の標準化に徹底
単一 exe にも対応
開発時は bin/Debug/net8.0/ を基準
公開 exe は publish/ フォルダ基準
AppContext.BaseDirectory を基準とする絶対パス運用
特徴
Output ディレクトリは常に存在し、なければ自動生成
GlobalPaths.cs でパスを集約、他クラスは参照のみ
開発時・単一 exe 運用時で同一コードが使用可能
バッチ処理開始・終了時のログ・Enter 待ちを標準化
利用方法
NuGet から追加（ローカルまたは公開）
GlobalPaths を参照してフォルダ／ファイルパスを利用
プロジェクト固有の入力ファイルや設定ファイルは自由に追加可能
using MyProject;

Console.WriteLine("処理開始");
Console.WriteLine($"InputDir: {GlobalPaths.InputDir}");
Console.WriteLine($"OutputDir: {GlobalPaths.OutputDir}");

// ここに処理

Console.WriteLine("処理完了");
Console.ReadLine();
想定される利用シーン
複数のバッチプロジェクトで共通の起動・終了処理を統一
プロジェクトごとの Input/Output フォルダを簡単に管理
小規模?中規模のバッチ処理でシンプルかつ安全な基盤を提供
開発者コメント

多機能化・装飾化されたライブラリは便利ですが、使わない機能や複雑な依存によりコストが増えます。
このフレームワークは、必要最小限のコアに徹することを最優先に設計しました。
ルールを守れば、どのプロジェクトにもシームレスに適用できます。
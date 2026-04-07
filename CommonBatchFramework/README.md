# CommonBatchFramework

Minimal, rule-based batch framework for .NET.

Provides a consistent structure for batch applications with standardized execution flow, paths, and logging.

---

## Features

* Unified execution flow (AppRunner)
* Centralized path management (GlobalPaths)
* Standardized logging (Console + Output/log.txt)
* Works for both development and single-file deployment

---

## Installation

```bash
dotnet add package CommonBatchFramework
```

---

## Usage

```csharp
using CommonBatchFramework.App;

AppRunner.Run(() =>
{
    var paths = new GlobalPaths();
    paths.EnsureDirectories();

    Log.Initialize(paths.OutputDir);

    Log.Info("Start");

    // your process

    Log.Info("End");
});
```

---

## Logging

* Output: Console and `Output/log.txt`
* Format:

```
[yyyy-MM-dd HH:mm:ss] Message
[yyyy-MM-dd HH:mm:ss] ERROR: Message
```

---

## Notes

* Designed for simple and stable batch processing
* Focused on rules, not features
* Extend as needed per project

---

## Repository

https://github.com/peguevra/CommonBatchFramework

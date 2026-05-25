# FlowCraft

FlowCraft is a Windows WPF graph editor for ATM/business flow configuration.

It uses `FlowCore` for `.dig`/`.dml` parsing and serialization, supports a development JSON format, and includes tooling for expression editing, validation, compare, and packaging.

## Projects

| Project | Path | Role |
|---|---|---|
| FlowCraft | `FlowCraft/FlowCraft.csproj` | Main WPF editor (`net8.0-windows`) |
| FlowCore.Core | `FlowCore/FlowCore.Core/FlowCore.Core.csproj` | Core parser/model library (`netstandard2.0`) |

Main solution: `FlowCraft.sln`

## Key capabilities

- Open/save `.dig` and `.dml` using FlowCore-compatible behavior.
- Open/save development JSON format (`.json` + `.data` package folder).
- Node graph editing with packages, connections, route points, and minimap.
- Inspector with multi-select support and expression-aware editing.
- Search, diff/compare, command palette, validation, and variable tooling.
- Light/Dark theme and keyboard shortcut support.

## Requirements

## Screen Shots

<img width="1918" height="1031" alt="2" src="https://github.com/user-attachments/assets/1145a8f7-ab65-4d13-849f-d9d7d691f827" />
<img width="821" height="552" alt="4" src="https://github.com/user-attachments/assets/ce8e4bb8-c92f-40d1-ac44-fc07b2b43397" />
<img width="1223" height="779" alt="5" src="https://github.com/user-attachments/assets/53f3277e-99bf-4197-996a-bde6e8cd286a" />
<img width="1481" height="890" alt="6" src="https://github.com/user-attachments/assets/46566e49-d35d-414e-8560-0036c6ab8da4" />
<img width="1022" height="669" alt="7" src="https://github.com/user-attachments/assets/db8e560d-7b67-474f-b9b7-5c0afd04d299" />





- Windows 10/11 (x64 recommended)
- .NET SDK 8.0+
- Visual Studio 2022/2026 with WPF workload

## Build

```powershell
dotnet restore FlowCraft.sln
dotnet build FlowCraft.sln -c Debug
```

Run the app:

```powershell
dotnet run --project FlowCraft/FlowCraft.csproj -c Debug
```

Build outputs are redirected to `Builds/` (not project `bin/`).

## Publish

Normal publish/build:

```powershell
dotnet build FlowCraft.sln -c Release
```

Obfuscated publish configuration:

```powershell
dotnet build FlowCraft.sln -c Publish
```

Notes:

- `Publish` configuration is wired for obfuscation in `FlowCraft/FlowCraft.csproj`.
- Local obfuscation machine settings should go into `FlowCraft/CommercialObfuscation.Local.props`.

## Formats

- `.dig`: production/runtime format (encrypted token format).
- `.dml`: XML graph format.
- `.json`: development-friendly project format (with package-split `.data` folder).

See `FORMAT_JSON.md` for JSON details.

## Repository layout

```text
FlowCraft.sln
FlowCraft/                 # WPF editor
FlowCore/                  # core backend library and related tools
Runtime/                   # runtime assets (xml/images)
Engine/                    # engine handoff package for runtime developers
Builds/                    # generated build outputs
```

## Documentation

- `USAGE_UI.md`
- `ROADMAP_UI.md`
- `FLOWCRAFT_IMPLEMENTED.md`
- `README_SHORTCUTS.md`
- `FORMAT_JSON.md`
- `EXPRESSION_LANGUAGE.md`
- `EXPRESSION_FUNCTION_SIGNATURES.md`
- `ENGINE_IMPLEMENTATION_SPEC.md`
- `INSTALLER_FILE_ASSOCIATIONS.md`
- `OBFUSCATION_RELEASE.md`

## Compatibility note

FlowCraft relies on FlowCore-compatible `.dig` and `NodeInfo.xml` behavior. If you change parser/schema behavior, treat it as a compatibility-impacting change and validate against sample files in `FlowCore/TestData/`.


## Source Code

This repository is intended for showcase and portfolio purposes only.

The full source code remains private.

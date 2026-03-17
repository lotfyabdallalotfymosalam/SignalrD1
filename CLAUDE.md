# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

ASP.NET Core 9.0 MVC application demonstrating real-time chat using SignalR. Uses the `.slnx` solution format (not `.sln`).

## Build & Run Commands

```bash
# Build
dotnet build SignalrD1/SignalrD1.csproj

# Run (launches on HTTPS with hot reload)
dotnet run --project SignalrD1/SignalrD1.csproj

# Watch mode
dotnet watch --project SignalrD1/SignalrD1.csproj
```

No test project exists yet. No package manager beyond NuGet (no npm/libman for client-side libs).

## Architecture

- **Solution file**: `SignalrD1.slnx` — single-project solution
- **Web project**: `SignalrD1/` — ASP.NET Core MVC with SignalR
- **Hubs**: `Hubs/ChatHub.cs` — SignalR hub mapped at `/chatHub`. Exposes `SendMessage(name, message)` which broadcasts via `Clients.All.SendAsync("NewMessage", ...)`
- **Controllers**: Standard MVC controllers (`HomeController`, `ChatController`) serving Razor views
- **Views**: `Views/Chat/Index.cshtml` — chat UI with inline JS that connects to the hub using the SignalR JS client (`signalr.js` loaded from `~/microsoft/signalr/dist/browser/`)
- **Routing**: Default MVC route `{controller=Home}/{action=Index}/{id?}`

## Key Details

- SignalR JS client is served from `wwwroot/microsoft/signalr/` (vendored, not from CDN or npm)
- No database integration yet — `ChatHub.SendMessage` has a placeholder comment for DB persistence
- No authentication/authorization configured beyond the default middleware

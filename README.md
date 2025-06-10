# Hearth

HybridHearth is a sample hybrid app built with **.NET 9** using .NET MAUI and Blazor. The solution contains:

- **HybridHearth** – the MAUI project that hosts the shared UI inside a web view.
- **HybridHearth.Web** – an ASP.NET Core server project.
- **HybridHearth.Web.Client** – a WebAssembly client project.
- **HybridHearth.Shared** – Razor components and services shared by all hosts.

## Building

1. Install the .NET 9 SDK and required workloads:
   ```bash
   dotnet workload install maui wasm-tools
   ```
2. Restore and build the solution:
   ```bash
   dotnet restore
   dotnet build HybridHearth.sln
   ```

## Running

Run any of the projects directly with `dotnet run`:

```bash
# Run the MAUI application
dotnet run --project HybridHearth/HybridHearth

# Run the ASP.NET Core server
dotnet run --project HybridHearth/HybridHearth.Web

# Run the WebAssembly client only
dotnet run --project HybridHearth/HybridHearth.Web.Client
```

Each host uses the components and services from `HybridHearth.Shared`.

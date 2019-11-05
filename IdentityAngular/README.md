# Runing the app

Due to know bug with ASP.NET Core You need to add manually missing using:
```csharp
using Microsoft.AspNetCore.Hosting
```

to **..\IdentityAngular\IdentityAngular\obj\Debug\netcoreapp3.0\Razor\Pages\Shared\_Layout.cshtml.g.cs** line No 15:

```csharp
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Hosting;
#nullable restore
```
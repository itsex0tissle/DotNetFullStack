var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DotNetFullStack_BlazorHybrid_Web>("dotnetfullstack-blazorhybrid-web");

builder.Build().Run();

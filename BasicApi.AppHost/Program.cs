using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);
builder.AddProject<Projects.BasicApi>("basicapi");

builder.Build().Run();

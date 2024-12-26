var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ERP>("erp");

builder.Build().Run();

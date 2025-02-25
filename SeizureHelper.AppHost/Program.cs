var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SeizureHelperAPI>("seizurehelperapi");

builder.Build().Run();

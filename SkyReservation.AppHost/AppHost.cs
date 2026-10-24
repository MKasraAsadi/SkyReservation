var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SkyReservation_WebAPI>("skyreservation-webapi");

builder.Build().Run();

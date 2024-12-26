# Base image for running the .NET application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Copy published application from the host to the container
COPY ./publish . 

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "ERP.dll"]

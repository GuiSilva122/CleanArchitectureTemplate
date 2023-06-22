FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# It's important to keep lines from here down to "COPY . ." identical in all Dockerfiles
# to take advantage of Docker's build cache, to speed up local container builds
COPY "CleanArchitectureTemplate.sln" "CleanArchitectureTemplate.sln"

COPY "BuildingBlocks/EventBus/EventBus/EventBus.csproj" "BuildingBlocks/EventBus/EventBus/EventBus.csproj"
COPY "BuildingBlocks/EventBus/EventBusRabbitMQ/EventBusRabbitMQ.csproj" "BuildingBlocks/EventBus/EventBusRabbitMQ/EventBusRabbitMQ.csproj"
COPY "BuildingBlocks/EventBus/IntegrationEventLogEF/IntegrationEventLogEF.csproj" "BuildingBlocks/EventBus/IntegrationEventLogEF/IntegrationEventLogEF.csproj"
COPY "BuildingBlocks/WebHost/WebHost.Customization/WebHost.Customization.csproj" "BuildingBlocks/WebHost/WebHost.Customization/WebHost.Customization.csproj"
COPY "Services/Ordering/Ordering.API/Ordering.API.csproj" "Services/Ordering/Ordering.API/Ordering.API.csproj"
COPY "Services/Ordering/Ordering.Domain/Ordering.Domain.csproj" "Services/Ordering/Ordering.Domain/Ordering.Domain.csproj"
COPY "Services/Ordering/Ordering.FunctionalTests/Ordering.FunctionalTests.csproj" "Services/Ordering/Ordering.FunctionalTests/Ordering.FunctionalTests.csproj"
COPY "Services/Ordering/Ordering.Infrastructure/Ordering.Infrastructure.csproj" "Services/Ordering/Ordering.Infrastructure/Ordering.Infrastructure.csproj"
COPY "Services/Ordering/Ordering.SignalrHub/Ordering.SignalrHub.csproj" "Services/Ordering/Ordering.SignalrHub/Ordering.SignalrHub.csproj"
COPY "Services/Ordering/Ordering.UnitTests/Ordering.UnitTests.csproj" "Services/Ordering/Ordering.UnitTests/Ordering.UnitTests.csproj"
COPY "Services/Services.Common/Services.Common.csproj" "Services/Services.Common/Services.Common.csproj"

COPY "docker-compose.dcproj" "docker-compose.dcproj"

COPY "Directory.Packages.props" "Directory.Packages.props"
COPY "NuGet.config" "NuGet.config"

RUN dotnet restore "CleanArchitectureTemplate.sln"

COPY . .
WORKDIR /src/Services/Ordering/Ordering.API
RUN dotnet publish --no-restore -c Release -o /app

FROM build as unittest
WORKDIR /src/Services/Ordering/Ordering.UnitTests

FROM build as functionaltest
WORKDIR /src/Services/Ordering/Ordering.FunctionalTests

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ordering.API.dll"]

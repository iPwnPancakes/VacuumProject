FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["VacuumWebApp/VacuumWebApp.csproj", "VacuumWebApp/"]
RUN dotnet restore "VacuumWebApp/VacuumWebApp.csproj"
COPY . .
WORKDIR "/src/VacuumWebApp"
RUN dotnet build "VacuumWebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VacuumWebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VacuumWebApp.dll"]

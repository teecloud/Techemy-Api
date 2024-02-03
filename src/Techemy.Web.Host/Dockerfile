FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Techemy.Web.Host/Techemy.Web.Host.csproj", "src/Techemy.Web.Host/"]
COPY ["src/Techemy.Web.Core/Techemy.Web.Core.csproj", "src/Techemy.Web.Core/"]
COPY ["src/Techemy.Application/Techemy.Application.csproj", "src/Techemy.Application/"]
COPY ["src/Techemy.Core/Techemy.Core.csproj", "src/Techemy.Core/"]
COPY ["src/Techemy.EntityFrameworkCore/Techemy.EntityFrameworkCore.csproj", "src/Techemy.EntityFrameworkCore/"]
WORKDIR "/src/src/Techemy.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Techemy.Web.Host", "src/Techemy.Web.Host"]
COPY ["src/Techemy.Web.Core", "src/Techemy.Web.Core"]
COPY ["src/Techemy.Application", "src/Techemy.Application"]
COPY ["src/Techemy.Core", "src/Techemy.Core"]
COPY ["src/Techemy.EntityFrameworkCore", "src/Techemy.EntityFrameworkCore"]
WORKDIR "/src/src/Techemy.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Techemy.Web.Host.dll"]

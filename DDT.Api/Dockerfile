FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["DDT.Api/DDT.Api.csproj", "DDT.Api/"]
COPY ["DDT.Domain/DDT.Domain.csproj", "DDT.Domain/"]
COPY ["DDT.Application/DDT.Application.csproj", "DDT.Application/"]
RUN dotnet restore "DDT.Api/DDT.Api.csproj"
COPY . ./
WORKDIR "/src/DDT.Api"
RUN dotnet build "DDT.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DDT.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app/out .
ENTRYPOINT ["dotnet", "DDT.Api.dll"]
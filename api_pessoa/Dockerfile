#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["api_pessoa/api_pessoa.csproj", "api_pessoa/"]
RUN dotnet restore "api_pessoa/api_pessoa.csproj"
COPY . .
WORKDIR "/src/api_pessoa"
RUN dotnet build "api_pessoa.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "api_pessoa.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "api_pessoa.dll"]
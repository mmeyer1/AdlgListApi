#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["AdlgListApi/AdlgListApi.csproj", "AdlgListApi/"]
RUN dotnet restore "AdlgListApi/AdlgListApi.csproj"
COPY . .
WORKDIR "/src/AdlgListApi"
RUN dotnet build "AdlgListApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdlgListApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdlgListApi.dll"]

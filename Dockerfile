FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["AirConditioner.Web/AirConditioner.Web.csproj", "AirConditioner.Web/"]
RUN dotnet restore "AirConditioner.Web/AirConditioner.Web.csproj"
COPY . .
WORKDIR "/src/AirConditioner.Web"
RUN dotnet build "AirConditioner.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AirConditioner.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AirConditioner.Web.dll"]
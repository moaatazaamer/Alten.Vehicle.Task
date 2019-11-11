#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["Alten.Microservice.VehicleStatus.API/Alten.Microservice.VehicleStatus.API.csproj", "Alten.Microservice.VehicleStatus.API/"]
RUN dotnet restore "Alten.Microservice.VehicleStatus.API/Alten.Microservice.VehicleStatus.API.csproj"
COPY . .
WORKDIR "/src/Alten.Microservice.VehicleStatus.API"
RUN dotnet build "Alten.Microservice.VehicleStatus.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Alten.Microservice.VehicleStatus.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Alten.Microservice.VehicleStatus.API.dll"]
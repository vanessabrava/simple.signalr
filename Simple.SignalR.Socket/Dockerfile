FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY *.sln ./
COPY Simple.SignalR.Socket/Simple.SignalR.Socket.csproj Simple.SignalR.Socket/
RUN dotnet restore Simple.SignalR.Socket/Simple.SignalR.Socket.csproj

COPY . .
WORKDIR /src/Simple.SignalR.Socket
RUN dotnet build Simple.SignalR.Socket.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Simple.SignalR.Socket.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Simple.SignalR.Socket.dll"]

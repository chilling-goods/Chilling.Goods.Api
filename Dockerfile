FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build 
COPY . ./app
WORKDIR /app

RUN dotnet restore
RUN dotnet build -c release -o published --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine3.15
EXPOSE 9001
ENV ASPNETCORE_ENVIRONMENT=Development

WORKDIR /src

COPY --from=build /app/published .
ENTRYPOINT ["dotnet", "Chilling.Goods.Api.dll"]
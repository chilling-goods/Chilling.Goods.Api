FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build 
WORKDIR /src

COPY . .

RUN dotnet restore && \
    dotnet build --no-restore -c Release
##########################################################
##########################################################
FROM build AS publish

RUN dotnet publish /src/Chilling.Goods.Api --no-restore --no-build -c Release -o /app
##########################################################
##########################################################

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine3.15

RUN apk add icu-libs

ENV ASPNETCORE_ENVIRONMENT=Development \
    ASPNETCORE_URLS="http://*:9001" \
    Kestrel_Endpoints_Http_Url="http://*:9001" \
    DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

WORKDIR /app
RUN adduser app -u 10001 -s /sbin/nologin -H -S && chmod 755 /app
COPY --from=publish /app .
USER app

ENTRYPOINT ["dotnet", "Chilling.Goods.Api.dll"]
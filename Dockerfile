FROM mcr.microsoft.com/dotnet/core/sdk:3.0-alpine

RUN apk add tzdata
RUN cp /usr/share/zoneinfo/GB /etc/localtime
RUN echo "GB" >  /etc/timezone
RUN apk del tzdata

#RUN apk add --no-cache icu-libs

#Copy in source code
WORKDIR /src
COPY . .

# Build of Web application to directory /app
RUN dotnet build "DateChecker.csproj" -c Release -o /app

WORKDIR /app
ENTRYPOINT ["dotnet", "DateChecker.dll"]
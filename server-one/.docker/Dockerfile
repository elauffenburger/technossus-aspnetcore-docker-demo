FROM microsoft/dotnet:latest

ADD . /app
WORKDIR /app

EXPOSE 5000
ENV ASPNETCORE_URLS=http://*:80;https://*:443

RUN ["dotnet", "restore"]
ENTRYPOINT ["dotnet", "run"]
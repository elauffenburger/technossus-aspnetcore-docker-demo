FROM microsoft/dotnet:latest

ADD . /app
WORKDIR /app

RUN ["dotnet", "restore"]
ENTRYPOINT ["dotnet", "run"]
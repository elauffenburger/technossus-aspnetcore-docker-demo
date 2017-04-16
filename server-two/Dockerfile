FROM microsoft/dotnet:latest

ADD . /app
WORKDIR /app

RUN ["dotnet", "restore"]

EXPOSE 5000
ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT ["dotnet", "run"]
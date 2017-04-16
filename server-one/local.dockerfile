FROM microsoft/dotnet:latest

ADD . /app
WORKDIR /app

EXPOSE 5000
ENV DOTNET_USE_POLLING_FILE_WATCHER=1
ENV ASPNETCORE_ENVIRONMENT=development
ENV ASPNETCORE_URLS=http://*:5000

CMD ["bash", "-c", "dotnet restore && dotnet watch run"]
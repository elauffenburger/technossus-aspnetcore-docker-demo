FROM microsoft/dotnet:latest

ADD . /app
WORKDIR /app

RUN ["dotnet", "restore"]

EXPOSE 80
EXPOSE 443
ENV ASPNETCORE_URLS http://*:80;https://*:443

ENTRYPOINT ["dotnet", "run"]
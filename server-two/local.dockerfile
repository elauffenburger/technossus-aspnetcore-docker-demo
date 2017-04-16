FROM microsoft/dotnet:latest

ADD . /app
WORKDIR /app

EXPOSE 5000
ENV ASPNETCORE_URLS=http://*:5000

CMD ["bash", "-c", "dotnet restore && dotnet watch run"]
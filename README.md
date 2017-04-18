# What is this?
This is a POC to demonstrate a practical development environment for ASP.NET Core in Docker.

# What's included?
  * Service-to-service communication
  * Rebuild & Run on file changes
  * Build-once images with data volumes
  * Conventions for easy docker-compose.yaml files

# How to run
## Development
  * Make sure you have environment variables for `SERVER_ONE_SRC` and `SERVER_TWO_SRC` that point to the respective directories for each service project
  * Go to the service you'd like to start (server-one is recommended) and run a cool `docker-compose -f .docker\docker-compose.yaml up -- build`
  * Now, try hitting the proxy service (server-one) at `http://localhost:8000/api/proxy/fortune`

## Production
  * Just run `docker build -f .docker/Dockerfile -t server-name . && docker run -d -p 80:80 -p 443:443 server-name`
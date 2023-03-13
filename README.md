Prepare for Dockerfile

Create your Dockerfile at the root, similar place with the .sln file.
for basic configuration your docker file loks like the following 

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine as build

WORKDIR /app

COPY . .

RUN dotnet restore

RUN dotnet publish -o /app/published-app


FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime

WORKDIR /app

COPY --from=build /app/published-app /app

ENTRYPOINT [ "dotnet", "/app/Doe.movie.dll" ]


Build the Image and Run the Container

Build your image use docker build . -t Doe.Movie

Run a container with previous image. docker run --name dotnetexample -p 8081:80 -d Doe.Movie  // note you can use any port

Check your container using . docker ps. command

then browse www.localhost:8081/movies/all 
you will get all movies from the image t

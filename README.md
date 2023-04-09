# Prepare for Dockerfile

# Create your Dockerfile at the root, similar place with the .sln file.
# for basic configuration your docker file loks like the following 

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine as build

WORKDIR /app

COPY . .

RUN dotnet restore

RUN dotnet publish -o /app/published-app


FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime

WORKDIR /app

COPY --from=build /app/published-app /app

ENTRYPOINT [ "dotnet", "/app/Doe.movie.dll" ]


# Build the Image and Run the Container

Build your image use docker build . -t Doe.Movie

Run a container with previous image. docker run --name dotnetexample -p 8081:80 -d Doe.Movie  // note you can use any port

# Check your container using . docker ps. command

then browse www.localhost:8081/movies/all 
you will get all movies from the image t


#  Option Two 
if your Project Has Dependency of any Other Project in your solution Follow this step 

# 1  go to Your Api Project Root and Add This Tag

   "<EnableSdkContainerSupport>true</EnableSdkContainerSupport>"

# 2  use the following Command To Publish and Create Image
 
 dotnet publish --os linux -c Release -p:PublishProfile=DefaultContainer -p:ContainerImageName=mycompany-hr-api

 it will Create Image with version 1.0.0 you can cutomize this latter as you want 

 # 3 Run your Image using the following command 

   docker run --name myhrcpntainer -p 8087:80 -d mycompany-hr-api:1.0.0

   thats it !!



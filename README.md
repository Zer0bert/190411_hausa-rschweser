# 190411_hausa-rschweser

## Create fresh microservice

`dotnet new webapi -o myMicroservice --no-https`

The dotnet command creates a new application of type webapi (that's a REST API endpoint).

The -o parameter creates a directory named myMicroservice where your app is stored.

The --no-https flag creates an app that will run without an HTTPS certificate, to keep things simple for deployment.

## Run microservice

`dotnet run`

Once the command completes, browse to http://localhost:5000/api/Values

## Docker integration

Check docker: `docker --version`

Create Docker image: `docker build -t mymicroservice .`

The docker build command uses the information from your Dockerfile to build a Docker image.

The -t mymicroservice parameter tells it to tag (or name) the image as mymicroservice.

The final parameter tells it which directory to find the Dockerfile in (. specifies the current directory).

List all docker images: `docker image ls`

`docker run -it --rm -p 3000:80 mymicroservice`

Once the command completes, browse to http://localhost:3000/api/values.

---

MD Help: https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet

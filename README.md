# docker-dotnet-testproj
Simple dotnet docker test project

## Environment variable
`LITEDBCONNECTIONSTRING` z.B. auf `/var/data/database.db` für docker volume

## API calls:
POST `https://localhost:5001/api/tasks/save`
BODY `{ "TaskItem": "Testaufgabe 1" }`

GET `https://localhost:5001/api/tasks/getall`

# Dockerunterstützung
## Schritt 1: `docker build .` im Verzeichnis DDT.Api
Kann dauern, lädt dotnet core

## Schritt 2: Docker Image pushen
`docker tag local-image:tagname new-repo:tagname`
`docker push new-repo:tagname`

# docker-dotnet-testproj
Simple dotnet docker test project

## Environment variable
`LITEDBCONNECTIONSTRING` z.B. auf `/var/data/database.db` für docker volume

## API calls:
POST `https://localhost:5001/api/tasks/save`  
BODY `{ "TaskItem": "Testaufgabe 1" }`

GET `https://localhost:5001/api/tasks/getall`

# Dockerunterstützung
## Schritt 1: `docker build -f "%pathto%\docker-dotnet-testproj\ddt.api\dockerfile" -t ddtapi  --label "com.microsoft.created-by=visual-studio" --label "com.microsoft.visual-studio.project-name=DDT.Api" "%pathto%\docker-dotnet-testproj"`  
Das %pathto% muss entsprechend angepasst werden. Der erste Buildvorgang kann tatsächlich etwas länger dauern, da dotnet core heruntergeladen wird.

## Schritt 2:: Docker Image lokal prüfen
Prüfen, ob Docker-Image lokal registriert ist: `docker images`  
Image testen: `docker run CONTAINER-ID`  
IP-Adresse herausbekommen: `docker inspect CONTRAINER-ID`  
Im Browser testen: `http://172.26.149.231/api/tasks/getall`  

## Schritt 3: Docker Image pushen
VS -> Rechtsklick SLN "DDT.Api" -> Publish -> Container Registration -> Docker-Hub

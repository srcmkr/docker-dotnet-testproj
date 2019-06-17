# docker-dotnet-testproj
Simple dotnet docker test project

## Environment variable
`LITEDBCONNECTIONSTRING` z.B. auf `/var/data/database.db` für docker volume

## API calls:
POST `https://localhost:5001/api/tasks/save`
BODY `{ "TaskItem": "Testaufgabe 1" }`

GET `https://localhost:5001/api/tasks/getall`


# sampledocker
SQL DOCKER create image -docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Pa55w0rd' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest

Execute command on sql -docker exec -it b6049807993d /opt/mssql-tools/bin/sqlcmd -s localhost -U SA -P 'Pa55w0rd'

docker ps - list active images

docker ps -a -list  images

Build image web api -docker build -t webapiqq . -f .\webapentityframeworkdocker\Dockerfile

Up docker containers - docker-compose --project-name testapp up

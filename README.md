# sampledocker
SQL DOCKER create image -docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Pa55w0rd' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest

Execute command on sql -docker exec -it b6049807993d /opt/mssql-tools/bin/sqlcmd -s localhost -U SA -P 'Pa55w0rd!'

docker ps - list active images

docker ps -a -list  images

Build image web api -docker build -t sampleapp . -f .\webapentityframeworkdocker\Dockerfile

Up docker containers - docker-compose --project-name testapp up


Use the docker exec -it command to start an interactive bash shell inside your running container. In the following example sql1 is name specified by the --name parameter when you created the container.

Bash

Copy
sudo docker exec -it sql1 "bash"
Once inside the container, connect locally with sqlcmd, using its full path.

Bash

Copy
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Pa55W0rd!"

From the sqlcmd command prompt, switch context to the new Sales database:

SQL
Copy
USE Sales;
Go
Select * from Products
Go


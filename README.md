# ConsoleDocker

-Publish Console App

//Create image
docker build -t <image_name> <dockerfile_path>

docker build -t consoleapp .

//list of images

docker images

//Create Container

docker create --name <container_name> <image_name>

docker create --name console_container consoleapp

//Start Container

docker start <container_name>

docker start console_container


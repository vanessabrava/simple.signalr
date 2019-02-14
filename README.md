## Latest Version of Common Tags
The following tags are the latest stable versions of the most commonly used images. The complete set of tags is listed further down.
* [`latest`](https://github.com/vanessabrava/simple.signalr)

SignalR in .NET Core is simple to build and easy to use, but using Docker containers to quickly load a socket is even better!

## Container sample: Run a simple application

Here's a simple example with some optionals to load the SignalR server application in Docker.

Pull image;
```shell
$ docker pull vanebranve/simple.signalr
```

Start the container;
```shell
$ docker run -d -p 5001:80 --name signalr-server --restart=always vanebranve/simple.signalr
```
### Explanation
* `-d`  to start the container in the background;
* `-p 5001:80` to choose a port other than the default, by redirecting port 80 to a port of your choice. I chose 5001, to the left is the new port and to the right is the container's default port. ;
* `--name signalr-server` to easily locate your container using a friendly name;
* `--restart=always` to automatically start the container if you restart Docker.

Check if the container is up!
```shell
$ docker ps
```

Output similar to this:
```text
CONTAINER ID    IMAGE                        COMMAND                   CREATED          STATUS          PORTS                   NAMES
8c4ca45aa47d    vanebranve/simple.signalr    "dotnet Simple.Signa…"    4 minutes ago    Up 4 minutes    0.0.0.0:5001->80/tcp    signalr-server
```
## General

### Hands-on
If you are running **simple.signalr** in a local Docker, just access the [http://localhost:5001/ws](http://localhost:5001/ws) url to connect to the socket!

Opening the url directly in the browser, the output will be `Connection ID required`

### Tip

This is just a simple application that you can use to make it easier to work as a developer on a proof of concept. If you want this SignalR in a productive environment, the risk is all yours!

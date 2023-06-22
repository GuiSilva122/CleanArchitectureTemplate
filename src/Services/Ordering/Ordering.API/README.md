# Orders Microservice

This is the Orders microservice, this whole project is based on the eShopOnContainers which is powered by Microsoft, based on a simplified microservices architecture and Docker containers.

## Getting Started

Make sure you have [installed](https://docs.docker.com/docker-for-windows/install/) and configured docker in your environment.

```powershell
docker-compose build
docker-compose up
```

>Note: If you are running this application in macOS then use `docker.for.mac.localhost` as DNS name in `.env` file and the above URLs instead of `host.docker.internal`.

### Architecture overview

This microservice, uses a lot of concepts, like DDD patterns, CQRS, protobuffer, GRPC.

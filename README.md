# MicroService-Modelo
Template for MicroService in .NET Core

Every time a developer bootstrap a new microservice, he/she needs to add some common code for some standard things like logging, authorization and many more. This project serves this need to create a code template for a standard microservice and make this template availabe via visual studio marketplace.

Common features to be implemented for basic Rest API template:
1. Logging using Serilog. :heavy_check_mark:
2. Authentication using JWT. :heavy_check_mark:
3. Prometheus for metrics. :heavy_check_mark:
4. Swagger Documentation. :heavy_check_mark:
5. Circuit breaker using polly with httpclient. :heavy_check_mark:
6. API Rate Limiting.
7. Centralized Logging.(ELK stack or Graylog).
8. Grafana integration. 

For set of microservices we also need to have API gateway with service discovery mechanism.
1. API Gateway with Ocelot
2. Service discovery using consul. 


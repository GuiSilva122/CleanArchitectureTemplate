﻿global using System.Net.Sockets;
global using System.Text;
global using System.Text.Json;
global using CleanArchitectureTemplate.BuildingBlocks.EventBus;
global using CleanArchitectureTemplate.BuildingBlocks.EventBus.Abstractions;
global using CleanArchitectureTemplate.BuildingBlocks.EventBus.Events;
global using CleanArchitectureTemplate.BuildingBlocks.EventBus.Extensions;
global using Microsoft.Extensions.Logging;
global using Polly;
global using Polly.Retry;
global using RabbitMQ.Client;
global using RabbitMQ.Client.Events;
global using RabbitMQ.Client.Exceptions;
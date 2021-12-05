﻿using Api.CrossCutting.Dtos;
using Api.Domain.Commands;
using Api.Domain.Handlers;
using Api.Domain.Interfaces;
using Api.Domain.Mongo;
using Api.Infrastructure.Context;
using Api.Repositories;
using Api.Services;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.Ioc
{
    public class IocBootstrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            MongoDbPersistence.Configure();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMongoDbClient, MongoDbClient>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IRequestHandler<CreateUserCommand, CommandReturnDto>, CreateUserCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateUserCommand, CommandReturnDto>, UpdateUserCommandHandler>();
            services.AddScoped<IRequestHandler<RemoveUserCommand, CommandReturnDto>, RemoveUserCommandHandler>();

        }
    }
}

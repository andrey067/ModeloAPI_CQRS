using System;
using Api.Domain.Entities;
using Api.Domain.Entities.ValueObject;

namespace Api.Domain.Builders
{
    public interface IUserBuilder
    {
        User Builder();
        User CreateUserBuilder();
        IUserBuilder WithId(string id);
        IUserBuilder WithName(Name name);
        IUserBuilder WithOccupation(string ocupation);        
        IUserBuilder WithBirthDate(DateTime birthDate);
        IUserBuilder WithDateRegister();
        IUserBuilder WithEmail(Email email);        
        IUserBuilder WithVerified(bool verified);
    }
}
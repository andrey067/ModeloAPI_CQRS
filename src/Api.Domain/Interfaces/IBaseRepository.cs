﻿using Api.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task Create(T obj);
        Task Update(T obj);
        Task Remove(string id);
        Task<T> Get(string id);
        Task<List<T>> GetAll();
    }
}
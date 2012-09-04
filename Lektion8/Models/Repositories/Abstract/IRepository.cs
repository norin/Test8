﻿using System;
using System.Collections.Generic;
using Lektion8.Models.Entities.Abstract;

namespace Lektion8.Models.Repositories.Abstract
{
    /// <summary>
    /// Interface för Repository
    /// </summary>
    public interface IRepository
    {
        List<T> All<T>() where T : IEntity;
        T Get<T>(Guid id) where T : IEntity;
        void Delete<T>(T t) where T : IEntity;
        void Save<T>(T t) where T : IEntity;
    }
}

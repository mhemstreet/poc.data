﻿using poc.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc.repo
{
    public interface IRepository<T> where T: IBaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(Guid Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}

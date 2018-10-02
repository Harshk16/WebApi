using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebApi.Core.Model.Interfaces;

namespace WebApi.Data.Repository
{
    public class GenericRepository<TModel> : IRepository<TModel> where TModel : class
    {
        private Entities _context;
        private readonly IDbSet<TModel> dbEntity;

        public GenericRepository()
        {
            _context = new Entities();
            dbEntity = _context.Set<TModel>();
        }

        public void Delete(Guid modelId)
        {
            TModel model = dbEntity.Find(modelId);
            dbEntity.Remove(model);
        }

        public TModel GetModelById(Guid modelId)
        {
            return dbEntity.Find(modelId);

        }

        public IEnumerable<TModel> GetModels()
        {
            return dbEntity.ToList();
        }

        public void InsertModel(TModel model)
        {
            dbEntity.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateModel(TModel model)
        {
            _context.Entry(model).State = EntityState.Modified;
        }
    }
}

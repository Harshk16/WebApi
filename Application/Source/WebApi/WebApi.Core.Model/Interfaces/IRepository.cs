using System;
using System.Collections.Generic;

namespace WebApi.Core.Model.Interfaces
{
    public interface IRepository<TModel> where TModel : class
    {
        IEnumerable<TModel> GetModels();

        TModel GetModelById(Guid modelId);

        void InsertModel(TModel model);

        void Delete(Guid modelId);

        void UpdateModel(TModel model);

        void Save();
    }
}

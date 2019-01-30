using System.Collections.Generic;

namespace SolidWorkshop
{
    public interface IDataService<T> where T : IEntity
    {
        void Save(T entity);
        IEnumerable<T> ReadAll();
    }
}
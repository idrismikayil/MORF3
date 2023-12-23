using Domain.Entities;
using Domain.Rules;

namespace Domain.Exceptions
{
    public class EntityNotFound<T>(object id) : 
        Exception($"{typeof(T).Name} with id {id} could not be found."), 
        INonSensitiveException 
        where T : BaseEntity
    {
        public object Id { get; } = id;
    }
}
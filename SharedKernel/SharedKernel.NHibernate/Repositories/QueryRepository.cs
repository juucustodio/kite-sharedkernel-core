using System.Linq;
using SharedKernel.Domain.Entities;
using SharedKernel.Domain.Repositories;
using NHibernate;

namespace SharedKernel.NHibernate.Repositories
{
    public class QueryRepository<T> : IQueryRepository<T> where T : EntityBase
    {
        public ISession Session { get; set; }

        public QueryRepository(ISession session)
        {
            Session = session;
        }

        public T Get(long id)
        {
            return Session.Get<T>(id);
        }

        public IQueryable<T> Query => Session.Query<T>();
    }
}
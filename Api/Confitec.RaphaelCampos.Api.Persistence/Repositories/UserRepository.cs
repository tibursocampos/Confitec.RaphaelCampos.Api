using Confitec.RaphaelCampos.Api.Domain.Entities;
using Confitec.RaphaelCampos.Api.Persistence.Context;
using Confitec.RaphaelCampos.Api.Persistence.Interfaces.Repositories;
using Confitec.RaphaelCampos.Api.Persistence.Repositories.Shared;

namespace Confitec.RaphaelCampos.Api.Persistence.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }
    }
}

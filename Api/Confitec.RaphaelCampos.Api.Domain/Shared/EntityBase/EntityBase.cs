using System;
using System.Diagnostics.CodeAnalysis;

namespace Learning.Api.PopularPharmacy.Models.Shared.EntityBase
{
    [ExcludeFromCodeCoverage]
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }
    }
}

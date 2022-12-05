using System.Diagnostics.CodeAnalysis;

namespace Confitec.RaphaelCampos.Api.Domain.Shared.ValuesObjects
{
    [ExcludeFromCodeCoverage]
    public class FullName
    {
        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public static FullName Create(string firstName, string lastName)
        {
            return new FullName(firstName, lastName);
        }
    }
}

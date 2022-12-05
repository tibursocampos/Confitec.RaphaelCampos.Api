using Confitec.RaphaelCampos.Api.Domain.Utils;
using System.Diagnostics.CodeAnalysis;

namespace Confitec.RaphaelCampos.Api.Domain.Shared.ValuesObjects
{
    [ExcludeFromCodeCoverage]
    public class Email
    {
        public Email(string userEmail)
        {
            UserEmail = userEmail;
        }

        public static Email Create(string userEmail)
        {
            return new Email(userEmail.ValidateEmailFormat());
        }

        public string UserEmail { get; }
    }
}

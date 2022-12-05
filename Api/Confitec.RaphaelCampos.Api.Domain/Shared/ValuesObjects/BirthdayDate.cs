using Confitec.RaphaelCampos.Api.Domain.Utils;
using System;

namespace Confitec.RaphaelCampos.Api.Domain.Shared.ValuesObjects
{
    public class BirthdayDate
    {
        public BirthdayDate(DateTime birthdayDate)
        {
            UserBirthdayDate = birthdayDate;
        }

        public static BirthdayDate Create(string birthdayDate)
        {
            var dateArray = birthdayDate.Split(Constants.DATE_SEPARATOR);
            DateTime birthday = new(Convert.ToInt32(dateArray[0]), Convert.ToInt32(dateArray[1]), Convert.ToInt32(dateArray[2]));
            return new BirthdayDate(Validations.IsValidBirthdayDate(birthday));
        }

        public static BirthdayDate Create(DateTime birthdayDate)
        {
            return new BirthdayDate(Validations.IsValidBirthdayDate(birthdayDate));
        }

        public DateTime UserBirthdayDate { get; }
    }
}

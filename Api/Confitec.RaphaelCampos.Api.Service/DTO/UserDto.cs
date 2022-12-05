using Confitec.RaphaelCampos.Api.Domain.Entities;
using Confitec.RaphaelCampos.Api.Domain.Shared;
using Confitec.RaphaelCampos.Api.Domain.Shared.Enums;
using Confitec.RaphaelCampos.Api.Domain.Utils;
using System;

namespace Confitec.RaphaelCampos.Api.Service.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public string UserBirthdayDate { get; set; }
        public Schooling Schooling { get; set; }

        public static bool IsValidEmail(string email)
        {
            return email.IsValidEmailFormat();
        }

        public static bool IsValidBirthdayDate(DateTime birthdayDate)
        {
            var result = DateTime.Now.CompareTo(birthdayDate);
            return result > (int)default;
        }

        public UserDto()
        {
        }

        public UserDto(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserEmail = user.UserEmail;
            UserBirthdayDate = user.UserBirthdayDate.ToString(Constants.DATE_FORMAT);
            Schooling = user.Schooling;
        }
    }
}

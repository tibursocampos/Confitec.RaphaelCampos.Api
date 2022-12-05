using Confitec.RaphaelCampos.Api.Domain.Shared.Enums;
using Confitec.RaphaelCampos.Api.Domain.Shared.ValuesObjects;
using System;

namespace Confitec.RaphaelCampos.Api.Domain.Entities
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public DateTime UserBirthdayDate { get; set; }
        public Schooling Schooling { get; set; }

        internal User()
        {
        }

        public User(string firstName, string lastName, string userEmail, DateTime birthdayDate, Schooling schooling)
        {
            FirstName = firstName;
            LastName = lastName;
            UserEmail = Email.Create(userEmail).UserEmail;
            UserBirthdayDate = BirthdayDate.Create(birthdayDate).UserBirthdayDate;
            Schooling = schooling;
        }

        public User(string firstName, string lastName, string userEmail, string birthdayDate, Schooling schooling)
        {
            FirstName = firstName;
            LastName = lastName;
            UserEmail = Email.Create(userEmail).UserEmail;
            UserBirthdayDate = BirthdayDate.Create(birthdayDate).UserBirthdayDate;
            Schooling = schooling;
        }

        public User(int id, string firstName, string lastName, string userEmail, DateTime birthdayDate, Schooling schooling)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserEmail = Email.Create(userEmail).UserEmail;
            UserBirthdayDate = BirthdayDate.Create(birthdayDate).UserBirthdayDate;
            Schooling = schooling;
        }

        public void Update(int id, string firstName, string lastName, string userEmail, string birthdayDate, Schooling schooling)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserEmail = Email.Create(userEmail).UserEmail;
            UserBirthdayDate = BirthdayDate.Create(birthdayDate).UserBirthdayDate;
            Schooling = schooling;
        }
    }
}

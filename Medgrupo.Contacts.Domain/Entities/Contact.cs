using System;
using System.Collections.Generic;

namespace Medgrupo.Contacts.Domain.Entities
{
    public class Contact : Entity
    {
        public Contact(string name, string gender, DateTime birth)
        {
            Name = name;
            Gender = gender;
            Birth = birth;
            CreateDate = LastUpdateDate = DateTime.Now;
            CalculateAge();
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public DateTime Birth { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }


        public void UpdateName(string name)
        {
            if (Name.Equals(name)) return;

            Name = name;
            EntityModified();
        }

        public void ChangeGender(string gender)
        {
            if (Gender.Equals(gender)) return;

            Gender = gender;
            EntityModified();
        }

        public void ChangeDateBirth(DateTime birth)
        {
            if (Birth == null || birth.Equals(DateTime.MinValue) || Birth.Equals(birth)) return;

            Birth = birth;
            CalculateAge();
            EntityModified();
        }

        protected void CalculateAge()
        {
            if (Birth == null) return;

            var birthdate = Birth;
            var today = DateTime.Now;
            var age = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-age)) 
                age--;

            Age = age;
            EntityModified();
        }

        public void EntityModified()
        {
            LastUpdateDate = DateTime.Now;
        }

    }
}
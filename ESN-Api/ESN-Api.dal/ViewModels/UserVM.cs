﻿using ESN_Api.ESN_Api.dal.Domain;

namespace ESN_Api.ESN_Api.dal.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public int GenderId { get; set; }

        public UserVM()
        {

        }

        public UserVM(User user)
        {
            Id = user.Id;
            Name = user.FirstName + user.Lastname;
            Email = user.Email;
            Username = user.Username;
            GenderId = user.GenderId;
        }
    }
}

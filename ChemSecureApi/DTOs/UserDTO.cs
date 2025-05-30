﻿using ChemSecureApi.Model;
using Microsoft.AspNetCore.Identity;

namespace ChemSecureApi.DTOs
{
    public class UserDTO 
    {
        public string Id { get; set; }
        public string  UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<Tank>? Tanks { get; set; }

    }
}

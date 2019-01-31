using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bit285_assignment2_login.Models
{
    public class PasswordSuggetionService
    {
        public string generatePassword(User user) { 
            List<string> _passwordOptions = new List<string>();
            int half = user.LastName.Length / 2;
            _passwordOptions.Add(user.FavoriteColor.Substring(0, 2) + "-" +
                                        user.FavoriteColor + "-" +
                                    user.LastName);
            _passwordOptions.Add(user.LastName + user.FavoriteColor);
            _passwordOptions.Add(user.LastName.Substring(0, half) + "-" +
                                    user.BirthYear + "-" +
                                    user.LastName.Substring(half,half));
            Random random = new Random();
            int index = random.Next(0,_passwordOptions.Count);
            return _passwordOptions[index];
        }
    }
}

using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using AcademyG.Week8.EsercizioFinale.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AcademyG.Week8.EsercitazioneFinale.EF.Repositories
{
    public class UserRepositoryEF : IUserRepository
    {
        private readonly RestaurantContext ctx;

        public UserRepositoryEF(RestaurantContext context)
        {
            this.ctx = context;
        }

        public bool AddItem(User newItem)
        {
            if(newItem == null)
            {
                return false;
            }
            if(GetUserByUsername(newItem.Username) != null)
            {
                return false;
            } else
            {
                try
                {
                    ctx.Users.Add(newItem);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    //SOSTITUIRE CON UN MODELLO CHE FA VEDERE UN MESSAGGIO PARTICOLARE
                    return false;
                }

            }
        }

        public IEnumerable<User> FetchAll()
        {
            throw new NotImplementedException();
        }

        public User GetUserByUsername(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                return null;
            }
            return ctx.Users.FirstOrDefault(x => x.Username.Equals(username));
        }

        public bool RemoveItem(User item)
        {
            throw new NotImplementedException();
        }
    }
}

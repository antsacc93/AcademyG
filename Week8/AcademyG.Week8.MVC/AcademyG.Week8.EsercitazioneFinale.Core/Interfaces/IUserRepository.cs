using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace AcademyG.Week8.EsercizioFinale.Core.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        public User GetUserByUsername(string username);

    }
}

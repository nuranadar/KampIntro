using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // MicroService
    class GamerManager : IGamerService
    {
        List<Gamer> gamers = new List<Gamer>();
        
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService) 
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Registration has been successfull for our new gamer " + gamer.FirstName +" "+ gamer.LastName );
            }
            else
            {
                Console.WriteLine("Verification is not approved for " + gamer.FirstName + " " + gamer.LastName);
            }         
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registiration has been deleted for " + gamer.FirstName + " " +  gamer.LastName ); 
        }

        public void List()
        {
            Console.WriteLine("Firstname \t Lastname");
            foreach (var gamer in gamers)
            {
                Console.WriteLine(gamer.FirstName + "\t" + gamer.LastName );
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Registration has been updated for " + gamer.FirstName + gamer.LastName);
        }
    }
}

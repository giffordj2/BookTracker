using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracker
{
    class UserInput : IUserInput
    {
        public string GetAuthorInput()
        {
            return Console.ReadLine();
        }

        public string GetGenreInput()
        {
            return Console.ReadLine();
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }

        public string GetTitleInput()
        {
            return Console.ReadLine();
        }
    }
}

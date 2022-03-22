using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracker.Tests
{
    class FakeUserInput : IUserInput
    {
        public string GetAuthorInput()
        {
            return "G. R. R. Martin";
        }

        public string GetGenreInput()
        {
            return "Fantasy";
        }

        public string GetInput()
        {
            throw new NotImplementedException();
        }

        public string GetTitleInput()
        {
            return "Game of Thrones";
        }
    }
}

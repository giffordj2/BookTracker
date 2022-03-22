using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracker
{
    public interface IUserInput
    {
        string GetInput();
        string GetTitleInput();
        string GetAuthorInput();
        string GetGenreInput();
    }
}

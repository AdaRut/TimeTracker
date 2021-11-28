using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Services.Interfaces.Services.Utils
{
    public interface IHashService
    {
        string HashPassword(string password);
        bool Validate(string password, string hasPassword);
    }
}

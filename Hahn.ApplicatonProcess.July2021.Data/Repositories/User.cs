using Hahn.ApplicatonProcess.July2021.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.July2021.Data.Repositories
{
    public class User:IUser
    {
        DataBaseContext DataBase = new DataBaseContext();
        
    }
}

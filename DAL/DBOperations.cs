using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorizationn.DAL
{
    public class DBOperations
    {
        public List<LoginTable> GetAllStudents()
        {
            using (LogEntity logEntity = new LogEntity())
            {
                return logEntity.LoginTable.ToList();
            }
        }
    }
}

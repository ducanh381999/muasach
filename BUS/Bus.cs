using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class Bus
    {
        Data da = new Data();
        Products pro = new Products();

        public int getUser(string username, string password)
        {
            string sql = "select COUNT(*) from admin where username=N'" + username + "' and password=N'" + password + "'";
            int index = (int)da.getCount(sql);
            return index;
        }
    }
}

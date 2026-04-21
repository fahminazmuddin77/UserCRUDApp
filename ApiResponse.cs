using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUDApp
{
    public class ApiResponse
    {
        public bool success { get; set; }
        public List<User> data { get; set; }
    }
}
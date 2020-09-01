using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
{
  "firstname" : "Roger",
  "lastname" : "Moore",
  "age" : 89,
  "isAlive" : false,
  "address" :
  {
    "streetAddress" : "1 Main Street",
    "city" : "London",
    "postCode" : "N1 3XX"
  },
    "phoneNumbers" :
    [
        {"type" : "home", "number" : "+61 03 1234 5678" },
        {"type" : "mobile", "number" : "+61 0405 111 222"}
    ]  
}
*/
namespace JSONParser
{
    class jsonPersonSimple
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
    }
}

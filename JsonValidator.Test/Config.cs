using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonValidator.Test
{
    public class Config
    {
        //Valid Cases
        public const string VALID_TEST1 = "{\"Egypt\": [5, 6, 7]}";
        public const string VALID_TEST2 = "{\"Egypt\": 5}";
        public const string VALID_TEST3 = "{\"Egypt\":[{\"contact_person\": \"mohamed\", \"orders\" : [{\"id\": 100, \"qty\": 1000}, {\"id\": 101, \"qty\":1000}] }],\"Ghana\": [{\"contact_person\": \"ahmed\", \"orders\" : [{\"id\": 200, \"qty\": 2000},{\"id\": 201}]}],\"Mexico\": [{\"contact_person\": \"mostafa\", \"orders\" : [{\"id\": 300, \"qty\": 3000},{\"id\": 301}]}] }";
        //Invalid Cases
        public const string INVALID_TEST1 = "{\"Egypt\": 5}}";
        public const string INVALID_TEST2 = "{\"Egypt\": [5, 6, 7}]";
        public const string INVALID_TEST3 = "{\"Egypt\":[{\"contact_person\": \"mohamed\", \"orders\" : [{\"id\": 100, \"qty\": 1000}], {\"id\": 101, \"qty\":1000}]}],\"Ghana\": [{\"contact_person\": \"ahmed\", \"orders\" : [{\"id\": 200, \"qty\": 2000},{\"id\": 201}]}],\"Mexico\": [{\"contact_person\": \"mostafa\", \"orders\" : [{\"id\": 300, \"qty\": 3000},{\"id\": 301}]}] }";
        public const string INVALID_TEST4 = "{\"Egypt\":[{\"contact_person\": \"mohamed\", \"orders\" : [{\"id\": 100, \"qty\": 1000}, {\"id\": 101, \"qty\":1000}] }]},\"Ghana\": [{\"contact_person\": \"ahmed\", \"orders\" : [{\"id\": 200, \"qty\": 2000},{\"id\": 201}]}],\"Mexico\": [{\"contact_person\": \"mostafa\", \"orders\" : [{\"id\": 300, \"qty\": 3000},{\"id\": 301}]}] }";

    }
}

using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class UserInfo
    {
        public int Id { get; set; }
        public string UserLoginName { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
        public string Sex { get; set; }
        public int? Age { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModel
{
    public class UserInfoViewModel
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public Dictionary<string, string> ExposedClaims { get; set; }
    }
}

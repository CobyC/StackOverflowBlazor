using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowBlazor.Client.Utils
{
public class AppState
{
    public AppState()
    {
        //this class is to help maintain application state.
    }

    public UserData UserData { get; set; }
}


    public class UserData
    {
        public UserData()
        {
        }

        public string SomeUserData { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppServerSide.Components
{
    public class MyComponentBase : ExampleBase
    {

        public override void Submit()
        {
            Console.Write("Submit clicked");
            base.Submit();
        }

    }
}

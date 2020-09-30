using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppServerSide.Components
{
    public abstract class ExampleBase : ComponentBase
    {
        public virtual void Submit()
        {
            //DoSomething
        }

        public virtual void Back()
        {
            //DoSomething else
        }

    }
}

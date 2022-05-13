using Labb2_Linq.Context;
using Labb2_Linq.Data;
using Labb2_Linq.Handler;
using Labb2_Linq.Models;
using System;
using System.Collections.Generic;

namespace Labb2_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyData.StartMyApp();
            RunHandler.RunMyApp();
        }
    }
}

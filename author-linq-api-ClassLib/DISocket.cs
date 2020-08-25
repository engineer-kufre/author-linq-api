using System;
using System.Collections.Generic;
using System.Text;

namespace author_linq_api_ClassLib
{
    //Dependency Injection occurs in this class
    public static class DISocket
    {
        public static ILinqOperations Isocket { get; set; }

        //connects the UI to the library by matching a plug instance to the interface socket
        public static void PlugSocket()
        {
            LinqOperations plug = new LinqOperations();
            Isocket = plug;
        }
    }
}

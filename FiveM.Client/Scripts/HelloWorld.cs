using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM.Client.Scripts
{
    internal class HelloWorld
    {
        private static readonly object _padlock = new();
        private static HelloWorld _instance;

        private HelloWorld()
        {
            Init();
            Debug.WriteLine("^2PHello World Script has been Initialized");
        }

        internal static HelloWorld Instance
        {
            get
            {
                lock (_padlock)
                {
                    return _instance ??= new HelloWorld();
                }
            }
        }

        private async void Init()
        {
            SetupEventHandler();
            SetupRegisterCommands();
        }

        private void SetupEventHandler()
        {
            //Main.Instance.EventHandlerDictionary.Add("someScript", new Action(someScript));
        }

        private void SetupRegisterCommands()
        {
            RegisterCommand("helloWorld", new Action(PTurfTest), false);
        }

        public void PTurfTest()
        {
            Debug.WriteLine($"Hello World");
        }
    }
}

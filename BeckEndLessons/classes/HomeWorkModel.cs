using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckEndLessons.classes
{
    public class HomeWorkModel : IWork
    {
        public string name = "";
        public string description = "";
        public int index = 0;
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Index { get => index; set => index = value; }

        public void WriteDescription(HomeWorkModel hwm, Action method )
        {
            WriteTextToConsole.WriteColoredText($"{hwm.Name}", $"Description: {hwm.Description}", foreColor: ConsoleColor.DarkCyan);
            method();
        }
    }
}

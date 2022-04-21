using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseClickSimulator
{
    public class FormData
    {
        public string TimeServer { get; set; }
        public int MouseX { get; set; }
        public int MouseY { get; set; }
        public DateTime ExecutionDateTime { get; set; }
        public int ExecutionMiliseconds { get; set; }
        public int Tick { get; set; }
        public bool Running { get; set; } = false;
    }
}

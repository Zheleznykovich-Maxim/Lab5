using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Process
    {
        public string Name { get; }
        public int ExecutionTime { get; }
        public int RemainingTime { get; private set; }
        public int Quantum { get; set; }
        public bool IsFinished = false;

        public Process(string name, int executionTime, int quantum)
        {
            Name = name;
            ExecutionTime = executionTime;
            RemainingTime = executionTime;
            Quantum = quantum;
        }

        public void Execute()
        {
            if (RemainingTime > 0)
            {
                RemainingTime -= Quantum;
                if (RemainingTime <= 0)
                {
                    IsFinished = true;
                }
            }
           
            
        }
    }
}

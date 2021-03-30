using System;

namespace Practise.Structures
{
    struct Process : IProcess, IEquatable<Process>
    {
        private string _name;
        
        public Process(string name)
        {
            this = new Process();
            Name = name;
        }

        public int RunningTime { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _name = value;
            }
        }

        public static void ChangeRunningTime(IProcess process)
        {
            process.RunningTime = 100;
        }

        public void Run()
        {
            Console.WriteLine("Process started");
        }

        public static Process operator ++(Process process)
        {
            process.RunningTime++;
            return process;
        }

        public static Process operator --(Process process)
        {
            process.RunningTime--;
            return process;
        }

        public bool Equals(Process process)
        {
            return string.Equals(Name, process.Name);
        }
    }
}

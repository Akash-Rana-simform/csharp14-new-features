using System;

namespace CSharp14Demo
{
    public static class PartialMembersDemo
    {
        public static void Run()
        {
            var demo = new Demo();

            demo.TestEvent += () => Console.WriteLine("Event fired");

            demo.RaiseEvent();
        }
    }

    public partial class Demo
    {
        // Public constructor
        public Demo()
        {
            Initialize();
        }

        // C# 14 Partial Constructor Declaration
        partial void Initialize();

        // C# 14 Partial Event Declaration
        public partial event Action TestEvent;

        public void RaiseEvent()
        {
            _testEvent?.Invoke();
        }
    }

    public partial class Demo
    {
        // Partial Constructor-like Implementation
        partial void Initialize()
        {
            Console.WriteLine("Initialization done");
        }

        private Action _testEvent;

        // C# 14 Partial Event Implementation
        public partial event Action TestEvent
        {
            add => _testEvent += value;
            remove => _testEvent -= value;
        }
    }
}
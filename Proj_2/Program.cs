using System;
namespace Proj_2
{
    class Program
    {
        static void Main(string[] args) {
            Message msg = new Message();
            Message msg2 = new Message();
            msg.name = "obj1";
            msg2.name = "obj2";
            msg.disp(20);
            msg2.disp(26);
            msg2.disp(34, 51);
            msg.disp(30, 50);
        }
    }
    class Message
    {
        public string name;
        int x,y;
        public Message()
        {
            Console.WriteLine("the name is given");
        }

        public void disp(int x)

        {
            Console.WriteLine($"the name is given {name}");
            Console.WriteLine($"one variable recived {x}");
        }
        public void disp(int x , int y) {
            Console.WriteLine($"the name is given {name}");
            Console.WriteLine($"two var recived {x} and {y}");
        }
    }

}

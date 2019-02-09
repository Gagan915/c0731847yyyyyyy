using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0731847
{
    class Program
    {
        static void Main(string[] args)

        {
            elevator e = new elevator();
            e.setup();
            e.traverselList();
        }
            class Node
        {
            public Node() { }
           public Node floor;
           public Node elevatorUp;
            public string FloorNumber;
        }
        class elevator {
            Node Head;
            Node FirstFloor;
            Node SecondFloor;
            Node ThirdFloor;
            Node FourthFloor;
           Node MainFloor;

            public void setup()
            {
                FirstFloor = new Node();
                SecondFloor = new Node();
                ThirdFloor = new Node();
                FourthFloor = new Node();
                Head = new Node();

                FirstFloor.FloorNumber = "First Floor";
                Console.WriteLine("floor number is {0}", FirstFloor.FloorNumber);
                FirstFloor.elevatorUp = SecondFloor;
                SecondFloor.FloorNumber = "Second Floor";
                SecondFloor.elevatorUp = ThirdFloor;
                ThirdFloor.FloorNumber = "Third Floor";
                ThirdFloor.elevatorUp = FourthFloor;
                FourthFloor.FloorNumber = "FourthFloor";
                FourthFloor.elevatorUp = null;


                Console.WriteLine("floor number is {0}", SecondFloor.FloorNumber);
            }

            public void traverselList()
            {
                Node Temp;
                Temp = Head.elevatorUp;
                Console.WriteLine("The first floor is " + Head.FloorNumber);
               while (true)
              {




                }

            }
        }
        }
    }


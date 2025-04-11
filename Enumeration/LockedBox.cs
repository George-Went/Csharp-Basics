using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Enumeration
{
    internal class LockedBox
    {
        enum Lid {open,closed};
        enum Lock {locked,unlocked};
        public void UseChest()
        {
            Lid boxLid = Lid.closed;
            Lock boxLock = Lock.locked;

            string enteredData = "";

            while (enteredData != "stop")
            {
                Console.WriteLine($"The box is {boxLid}");
                Console.WriteLine($"The box is {boxLock}");

                Console.Write("\nWhat do you want to do? [open/close/lock/unlock/stop]: ");
                enteredData = Console.ReadLine();

                // Entered "open" -----------------------------
                if (enteredData == "open")
                {
                    // if open 
                    if (boxLid == Lid.open)
                    {
                        Console.WriteLine($"The box is already open");
                    }
                    // if closed
                    else if (boxLid == Lid.closed)
                    {
                        boxLid = Lid.open;
                        Console.WriteLine("Opening the box");
                    }
                }

                // Entered "close" -----------------------------
                else if (enteredData == "close")
                {
                    // if open 
                    if (boxLid == Lid.open)
                    {
                        boxLid = Lid.closed;
                        Console.WriteLine($"Closing the box");
                    }
                    // if closed
                    else if (boxLid == Lid.closed)
                    {
                        boxLid = Lid.open;
                        Console.WriteLine("Opening the box");
                    }
                }

                // Entered "lock" -----------------------------
                else if (enteredData == "lock")
                {
                    // if open 
                    if (boxLid == Lid.open)
                    {
                        Console.WriteLine($"The box is open, you cant lock it");
                    }

                    // if closed
                    else if (boxLid == Lid.closed)
                    {
                        // if locked
                        if (boxLock == Lock.locked)
                        {
                            Console.WriteLine($"The box is already locked");
                        }
                        // if unlocked
                        else if (boxLock == Lock.unlocked)
                        {
                            boxLock = Lock.locked;
                            Console.WriteLine("Its already locked");
                        }
                    }
                }

                // Entered "unlock" -----------------------------
                else if (enteredData == "unlock")
                {
                    // if open 
                    if (boxLid == Lid.open)
                    {
                        Console.WriteLine($"The box is open, you cant unlock it");
                    }

                    // if closed
                    else if (boxLid == Lid.closed)
                    {
                        // if locked
                        if (boxLock == Lock.locked)
                        {
                            boxLock = Lock.unlocked;
                            Console.WriteLine("Unlocking the box");
                        }
                        // if unlocked
                        else if (boxLock == Lock.unlocked)
                        {
                            Console.WriteLine("Its already unlocked");
                        }
                    }
                }
            }
        }
    }
}

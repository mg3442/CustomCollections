using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoublyLinkedList;
using NLog;

namespace ConsoleUI
{
    class Program
    {
       private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {                      
            Console.WriteLine("Double linked list usage:");
            DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
            try
            {             
                linkedList.AddFirst("Andy");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("cant be null");
                logger.Error("ArgumentNullException");
            }

            try
            {
                linkedList.AddLast("Tom");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("cant be null");
                logger.Error("ArgumentNullException");
            }  
            
            Console.WriteLine(linkedList.FindIdOfElement("Tom"));
            Console.WriteLine(linkedList.Remove("Tim"));
        }
    }
}

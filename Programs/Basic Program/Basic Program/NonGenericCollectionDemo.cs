using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class NonGenericCollectionDemo
    {
        public void ArrayListElements()
        {
            ArrayList numbers = new ArrayList();  //list element ie) numbers is always in plural
            numbers.Add(110);
            numbers.Add("Rad");
            numbers.Add(20);
            numbers.Add(3);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            //numbers.Clear();
            //Console.WriteLine(numbers);

            // Console.WriteLine(numbers.Average());
            // Console.WriteLine(numbers.Sum());

        }
        public void StackElements()
        {
            Stack numbers = new Stack();
            numbers.Push("100");
            numbers.Push(200);
            numbers.Push(-100);
            

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(numbers.Pop());

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public void QueueElements()
        {
            Queue numbers = new Queue();

            numbers.Enqueue(100);
            numbers.Enqueue(200);
            numbers.Enqueue(-100);
            

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(numbers.Dequeue());

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public void HashElements()
        {
            Hashtable students = new Hashtable();
            students.Add(1, 100);
            students.Add(2, 200);

            foreach (var key in students.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var val in students.Values)
            {
                Console.WriteLine(val);
            }

            foreach (var key in students.Keys)
            {
                Console.WriteLine(students[key]);
            }

        }

        public void SortedListElements()
        {
            SortedList students = new SortedList();
            students.Add(1, 100);
            students.Add(2, 200);

            foreach (var key in students.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var val in students.Values)
            {
                Console.WriteLine(val);
            }

            foreach (var key in students.Keys)
            {
                Console.WriteLine(students[key]);
            }
        }
    }
}

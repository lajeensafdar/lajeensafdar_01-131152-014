using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace Student_pro
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentInput;
            String Choice;
            Console.WriteLine("Please press ");
            Console.WriteLine("1.To Create Student Profile");
            Console.WriteLine("2. Search Student ");
            Choice = Console.ReadLine();
            if (Choice == "1")
            {
                using (StreamWriter obj = new StreamWriter("D:/DataStudent.txt", true))
                {
                    Console.WriteLine("Please enter Your ID number");
                    studentInput = Console.ReadLine();
                    obj.WriteLine(studentInput);
                    Console.WriteLine("Please enter Your Name");
                    studentInput = Console.ReadLine();
                    obj.WriteLine(studentInput);
                    Console.WriteLine("Please enter Your  Semester");
                    studentInput = Console.ReadLine();
                    obj.WriteLine(studentInput);
                    Console.WriteLine("Please enter Your CGPA");
                    studentInput = Console.ReadLine();
                    obj.WriteLine(studentInput);
                    Console.WriteLine("Please enter Your Department");
                    studentInput = Console.ReadLine();
                    obj.WriteLine(studentInput);
                    Console.WriteLine("Please enter Your University");
                    studentInput = Console.ReadLine();
                    obj.WriteLine(studentInput);
                }

            }
            else if (Choice == "2")
            {
                using (StreamReader obj = new StreamReader("D:/DataStudent.txt"))
                {
                    string storingdata = null, line;
                    Console.WriteLine("Please Enter 1.for ID search ");
                    Console.WriteLine("Please Enter 2.for Name search ");
                    Console.WriteLine("Please Enter 3.for Semester search ");
                    Choice = Console.ReadLine();

                    if (Choice == "1")
                    {
                        Console.WriteLine("Please Enter ID ");
                        Choice = Console.ReadLine();
                        while ((line = obj.ReadLine()) != null)
                        {

                            if (line == Choice)
                            {
                                storingdata += line;
                                for (int i = 0; i < 5; i++)
                                    storingdata += "\t" + obj.ReadLine();
                            }
                        }
                        Console.WriteLine("The Given Data we get : ");
                        Console.WriteLine(storingdata);
                    }
                    else if (Choice == "2")
                    {
                        Stack stack = new Stack();
                        Console.WriteLine("Please Enter Name ");
                        Choice = Console.ReadLine();
                        while ((line = obj.ReadLine()) != null)
                        {

                            if (line == Choice)
                            {
                                storingdata += stack.Pop() + "\t" + line;
                                for (int i = 0; i < 4; i++)
                                    storingdata += "\t" + obj.ReadLine();
                            }
                            stack.Push(line);
                        }
                        Console.WriteLine("The Given Data we get : ");
                        Console.WriteLine(storingdata);

                    }
                    else if (Choice == "3")
                    {
                        Stack stack = new Stack();
                        Console.WriteLine("Please Enter Semester ");
                        Choice = Console.ReadLine();
                        while ((line = obj.ReadLine()) != null)
                        {

                            if (line == Choice)
                            {
                                storingdata += "\n" + stack.Pop() + "\t" + stack.Pop() + "\t" + line;
                                for (int i = 0; i < 3; i++)
                                    storingdata += "\t" + obj.ReadLine();

                            }
                            stack.Push(line);
                        }
                        Console.WriteLine("The Given Data we get : ");
                        Console.WriteLine(storingdata);
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                    }

                }


            }
            else
            {
                Console.WriteLine("Wrong Input");
            }



            Console.ReadKey();
        }
    }
}

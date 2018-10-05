﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO; //Used for file and FileInfo Class
using mosh_csharp_basic.primitive;
using mosh_csharp_basic.nonprimitive;
using mosh_csharp_basic.nonprimitive.classes;
using mosh_csharp_basic.control_flow;
using mosh_csharp_basic.control_flow.condition_exercises;
using mosh_csharp_basic.control_flow.Iteration_statements;
using mosh_csharp_basic.arrys_and_lists;
using mosh_csharp_basic.working_with_dates;
using mosh_csharp_basic.working_with_files;
using mosh_csharp_basic.working_with_files.file_and_fileInfo;
using mosh_csharp_basic.working_with_text;
using mosh_csharp_basic.working_with_text.exercise_with_working_with_text;
using mosh_csharp_basic.working_with_text.procedural_programming;
using mosh_csharp_basic.working_with_files.Directory_and_DirectoryInfo;
using mosh_csharp_basic.working_with_files.path;
using mosh_csharp_basic.working_with_files.working_with_files_exercises;

namespace mosh_csharp_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //filesex1 filesex1 = new filesex1();
            //filesex1.GetFileEx1();

            //filesex2 filesex2 = new filesex2();
            //filesex2.GetFileEx2();

            List<int> numbers = new List<int>();
            const int Limit = 5;
            int input;

            do
            {
                Console.Write("Enter a number: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(input))
                {
                    Console.WriteLine();
                    Console.WriteLine("You have enter this number before");
                    Console.WriteLine("Please re-enter a unique number...");
                    Console.WriteLine();
                    continue;
                }

                numbers.Add(input);

            } while (numbers.Count < Limit);

            numbers.Sort();

            Console.WriteLine("\nSorted List:");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }

    }
}

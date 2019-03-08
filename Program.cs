using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.CSharp;

namespace RoslynTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutionPath = @"C:\\Users\\Camilo\\Desktop\\Slicer\\abstract_dynamic_slicer_demo\\example\\src\\example_project.sln";

            var workspace = MSBuildWorkspace.Create();
            var solution = workspace.OpenSolutionAsync(solutionPath).Result;
            var project = solution.Projects.First();
            var compilation = project.GetCompilationAsync().Result;
            compilation.Emit(@".\\YourExecutable.exe");

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

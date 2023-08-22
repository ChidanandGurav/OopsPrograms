using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Inheritance
{
    public interface IStudent
    {
        string Display();
    }

    public interface IMarks
    {
        string Display();
    }

    public class Display : IStudent ,IMarks
    {
        string IStudent.Display()
        {
            return $" Id = {1} , Name = {"Omkar"} , Standard = {"5th"}";
        }

        string IMarks.Display()
        {
            return $" English = {85}, Maths = {65} , Science = {72}";
        }
    }
}

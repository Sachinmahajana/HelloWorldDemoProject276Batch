using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemoProject276Batch
{
    public class Human
    {
        //instance variables
        //name,height,weight,Age
        //syntax:acessmodifier datatype variable
        public string name;
        public float height, weight;
        public int Age;

        // instance
        public void Speak() //method defination/Signature
        {
            //method body or implementation 
            Console.WriteLine("Human can speak");
        }
        //instance
        public void HumanDetails(string humanName, float humanHeight, float humanWeight, int humanAge) //method defination/Signature
        {
            //method body or implementation
            Console.WriteLine("Human Details:{0} {1} {2} {3}", humanName, humanHeight, humanWeight, humanAge);
        }
    }
}

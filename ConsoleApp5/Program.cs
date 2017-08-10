using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataList
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            while(true)
            {
                controller.GetHintProvider();
            }
            
            
            
            
            
            //new List<string>()
            //{
            //    { "Apoorva Kumar Pandey"},
            //    { "Subham Saraf"},
            //    { "Deependra Tripathi"},
            //    { "Himanshu Soni"},
            //    { "Divas Agarwal"},
            //    { "Amit Prakash"},
            //    { "Shubhangi Bisaria"},
            //    { "Samiksha Chandak"},
            //    { "Bandana Mahapatra"},
            //    { "Smita Acharya"},
            //    { "Suraj Narayan"},
            //    { "Sakshi Sharma"},
            //    { "Prabhas Mohanty"},
            //    { "Pratik Kumar"},
            //    { "Pankaj Kawale"},
            //};
            Console.ReadKey(true);
        }
    }
}




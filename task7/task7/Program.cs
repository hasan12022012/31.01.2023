using System;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş yazını əks şəkildə qaytaran metod

           var newName = StringName("Tetris");
            
            

        }
        static string StringName(string str)
        {
            string name = "Tetris";
            string newName= "";
           
            for (int i=name.Length-1;i>=0;i--)
            {
                newName += name[i];
                    
            }
            return(newName);
            
        }

    }
}

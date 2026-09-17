//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{ 

//    class Animal 
//    {
//        public virtual void animalsound()
//        {
//            Console.WriteLine("This animal makes a sound");
//        }
//    }

//    class Lion : Animal
//    {
//         public override void animalsound()
//        {   
//            Console.WriteLine("The king \"ROARS\" ");
//        }
//    }

//    class Elephant : Animal
//    {
//        public override void animalsound()
//        {
//            Console.WriteLine("The Mighty Elephant Trumphs");
//        }
//    }

//    internal class Polymorphism  
//    {
//        static void Main(string[] args)
//        {
//            Animal an = new Animal();
//            Animal lion = new Lion();
//            Animal El = new Elephant();

//            an.animalsound();
//            lion.animalsound();
//            El.animalsound();
//        }
//    }
//}

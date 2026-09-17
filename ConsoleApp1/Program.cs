////Console.WriteLine("Hello, World!");
////float f1 = 35e3F;
////double d1 = 12E4D;
////Console.WriteLine(f1);
////Console.WriteLine(d1);

////bool isCSharpFun = true;
////bool isFishTasty = false;
////Console.WriteLine(isCSharpFun);   // Outputs True
////Console.WriteLine(isFishTasty);

////double db = 129000; 
////int myint = (int)db;
////Console.WriteLine(myint);

////int myInt = 10;
////double myDouble = 5.25;
////bool myBool = true;

////Console.WriteLine(Convert.ToString(myInt));    // convert int to string
////Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
////Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
////Console.WriteLine(Convert.ToString(myBool));

////string interpolation

////string firstName = "John";
////string lastName = "Patel";
////string name = $"My Full Name is : {firstName} {lastName}";
////Console.WriteLine(name);

////string name = "Manan Patel";
////Console.WriteLine(name.IndexOf(" "));

////Console.WriteLine("The so called \"INVINCIBLE\" GOJO");

////Console.WriteLine("It\'s Ok");

////int x = 10;
////int y = 20;

////Console.WriteLine(x > y);

////int x = 20;
////string result = (x > 18) ? "Eligible for vote" : "Not eligible";
////Console.WriteLine(result);
////string[] cars = { "BMV", "Merci", "FERRARI", "lambo" };
////foreach (string car in cars)
////{
////    Console.WriteLine(car);
////}

////string[] Cars = new string[4];

////int[] arr = new int[5];
////for(int i = 0; i < arr.Length; i++)
////{
////    arr[i] = int.Parse(Console.ReadLine());
////}

////arr.Sort(arr);

////for(int i  = 0;i < arr.Length;i++)
////{
////    Console.WriteLine($"Number {i}: {arr[i]}");
////}


//// MULTIDIMENSIONAL ARRAY

////int[,] numbers = { { 1, 4, 2 } , { 1, 4, 6 } };

////numbers[0, 0] = 5;
////Console.WriteLine(numbers[0,0]);


////int[,] numbers = { { 1, 4, 5 }, { 2, 5, 6 } };

////for(int i = 0; i < numbers.GetLength(0); i++)
////{
////   for(int j = 0; j < numbers.GetLength(1); j++) 
////{
////    Console.WriteLine(numbers[i,j]);
////}
////}   

//using System.ComponentModel.DataAnnotations;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        //METHOD OVERLOADING
//        //static float AreaCalc(int x , int y)
//        //{
//        //    float area = x * y;
//        //    return area;
//        //}
//        //static float AreaCalc(int x, int y,int z)
//        //{
//        //    float area = x * y;
//        //    return area;
//        //}
//        //static float AreaCalc(float x, float y)
//        //{
//        //    float area = x * y;
//        //    return area;
//        //}


//        //CLASSES AND OBJECTS (SINGLE AND MULTIPLE)
//        //public class Car
//        //{
//        //    public string color = "red";
//        //}


//        //public class MyClass    
//        //{
//        //    public string color = "red";
//        //    public int maxspeed = 200;
//        //    public void fullThrottle()
//        //    {
//        //    Console.WriteLine("The car is going as fast as it can!");
//        //    }
//        //}

//        //CONSTRUCTOR
//        class Car
//        {
//            public string model;

//            public Car()
//            {
//                model = "Lambo";
//            }


//        }

//        static void Main(string[] args)
//        {


//            Car c = new Car();
//            Console.WriteLine(c.model);



//            // 1. Create a new copy of your Greeter class
//            //NewClass nw = new NewClass();

//            //// 2. Call the method inside it
//            //nw.SayHello("Alice");

//            //// Keeps the terminal window open until you press a key
//            //Console.ReadLine();
//            //Console.WriteLine("Enter the length of the rectangle");
//            //int length = int.Parse(Console.ReadLine());
//            //Console.WriteLine("Enter the width of the rectangle");
//            //int width = int.Parse(Console.ReadLine());
//            //int result = nw.CalcArea(length ,width);
//            //Console.WriteLine($"The area of the rectangle is : {result}");
//            //Console.ReadLine(); // Keeps terminal open

//            //NewClass.MyMethod("Sweden");
//            //NewClass.MyMethod("India");   
//            //NewClass.MyMethod();
//            //NewClass.MyMethod("USA");


//            //METHOD OVERLOADING
//            //float result = AreaCalc(5, 7);
//            //float result2 = AreaCalc(5, 7,8);
//            //float result3 = AreaCalc(5.3f,7.5f);
//            //Console.WriteLine(result);
//            //Console.WriteLine(result2);
//            //Console.WriteLine(result3);


//            //CLASSES AND OBJECTS (SINGLE AND MULTIPLE)

//            //Car c = new Car();
//            //Car NewCar = new Car();
//            //NewCar.color = "blue";
//            //Console.WriteLine(NewCar.color);
//            //Console.WriteLine(c.color);

//            //MyClass my = new MyClass();
//            //my.fullThrottle();
//            //my.maxspeed = 600;
//            //my.color = "red";
//            //Console.WriteLine(my.maxspeed);
//            //Console.WriteLine(my.color);



//        }
//    }   
//}
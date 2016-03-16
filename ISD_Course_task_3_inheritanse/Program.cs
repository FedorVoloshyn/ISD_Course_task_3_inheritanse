using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_3_inheritanse
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosen_exersise = -1;

            while (chosen_exersise != 0)
            {
                Console.WriteLine("\tISD Course. Task 3. Homework by Fedor Voloshyn.\n");
                Console.WriteLine("Enter number of exercise or '0' to exit: ");
                chosen_exersise = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (chosen_exersise)
                {
                    case 0: Console.WriteLine("Have a nice day!");
                        break;
                    case 1: ExerciseOne();
                        break;
                    case 2: ExerciseTwo();
                        break;
                    case 3: ExerciseThree();
                        break;
                    case 4: ExerciseFour();
                        break;
                    default: Console.WriteLine("Looks like you entered wrong number! Try again ;)");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void ExerciseOne()
        {
            BaseClass MyBaseClass = new BaseClass();
            MyBaseClass.Print("MyBaseClass.Print();");
            MyBaseClass = new Daughter();
            MyBaseClass.Print("MyDaughter.Print();");
        }
        public static void ExerciseTwo()
        {
            ClassRoom MyClassRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new GoodPupil());
            MyClassRoom.AddPupil(new BadPupil());
            MyClassRoom.ShowRating();
        }
        public static void ExerciseThree()
        {
            Car MyCar = new Car(2015, 200, 15000);
            Console.WriteLine("Car\n\tYear: {0}\n\tSpeed: {1}\n\tPrice: {2}", MyCar.YearDevelop, MyCar.Speed, MyCar.Price);

            Plane MyPlane = new Plane(2015, 600, 1500000, 5000, 10);
            Console.WriteLine("Plane\n\tYear: {0}\n\tSpeed: {1}\n\tPrice: {2}", MyPlane.YearDevelop, MyPlane.Speed, MyPlane.Price);
            Console.WriteLine("\tHeight: {0}\n\tPassengers: {1}", MyPlane.Height, MyPlane.NumberOfPassengers);

            Ship MyShip = new Ship(2015, 100, 50000, "My port", 20);
            Console.WriteLine("Ship\n\tYear: {0}\n\tSpeed: {1}\n\tPrice: {2}", MyShip.YearDevelop, MyShip.Speed, MyShip.Price);
            Console.WriteLine("\tPort: {0}\n\tPassengers: {1}", MyShip.Port, MyShip.NumberOfPassengers);
        }
        public static void ExerciseFour()
        {
            Console.WriteLine("Enter key to get Pro or Exp version, or press 'Enter' to get Basic: ");
            DocumentWorker docWorker;
            switch(Console.ReadLine().ToLower())
            {
                case "pro": docWorker = new ProDocumentWorker();
                    break;
                case "exp": docWorker = new ExpertDocumentWorker();
                    break;
                default: docWorker = new DocumentWorker();
                    break;
            }
            docWorker.OpenDocument();
            docWorker.EditDocument();
            docWorker.SaveDocument();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagocchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal stray_dog = new Animal("Dog", "Stray");
            stray_dog.Voice();

            Food fruitApple = new Food { type = "apple", health = 5 };
            Food chocolate = new Food { type = "chocolate", health = -5 };


            Animal.DoMeal(stray_dog, fruitApple);

            stray_dog.Play();
            stray_dog.Run();
            stray_dog.Play();
            stray_dog.Run();
            stray_dog.Play();
            stray_dog.Run();
            stray_dog.Play();
            stray_dog.Run();

            Animal.DoMeal(stray_dog, fruitApple);

            stray_dog.Play();
            stray_dog.Run();

            Animal.DoMeal(stray_dog, chocolate);

            stray_dog.Play();
            stray_dog.Run();

            Animal.DoMeal(stray_dog, chocolate);
            Animal.DoMeal(stray_dog, chocolate);
            Animal.DoMeal(stray_dog, chocolate);

            Console.WriteLine("Dog should be dead by now. RIP \n This program is waiting 30 sec to finish.");
            System.Threading.Thread.Sleep(30000);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagocchi
{
    struct Food
    { // структура Food для поддержания здоровья
        public string type;
        public int health;
    }

        class Animal
    {
        string name;
        int health;
        string voiceSound;
        string type;

        // animal constructor
        public Animal(string typeInp = "Dog", string nameInp = "Stray",
            int healthInp = 5, string voiceSoundInp = "Growl")
        {
            this.type = typeInp;
            this.name = nameInp;
            this.health = healthInp;
            this.voiceSound = voiceSoundInp;
            Console.WriteLine($"Created {this.type} {this.name} with {this.health}");
        }

        private bool CheckAlive()
        {
            if (this.health <= 0)
            {
                Console.WriteLine($"{this.type} {this.name} is dead and can't do anything");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Voice()
        {
            if (this.CheckAlive())
            {
                Console.WriteLine($"{this.type} {this.name}:*{this.voiceSound}*");
            }
        }
        public void Eat(Food f)
        {
            if (this.CheckAlive()) // Dead animals can't eat
            {
                Console.WriteLine($"{this.type} {this.name} eats {f.type}. {f.health} hp.");
                this.health += f.health;
            } 
        }

        public void Play()
        {
            if (this.CheckAlive())
            {
                if (this.health >= 5)
                {
                    Console.WriteLine($"{this.type} {this.name} has successfully played! Calories lost.");
                    this.health -= 1;
                }
                else
                {
                    Console.WriteLine($"{this.type} {this.name} is too hungry to play and is vocalizing it's hungriness!");
                    this.Voice();
                }
            }
        }
        public void Run()
        {
            if (this.CheckAlive())
            {
                if (this.health >= 5)
                {
                    Console.WriteLine($"{this.type} {this.name} has successfully ran! Calories lost.");
                    this.health -= 2;
                }
                else
                {
                    Console.WriteLine($"{this.type} {this.name} is too hungry to run and is vocalizing it's hungriness!");
                    this.Voice();
                }
            }
        }

        static public void DoMeal(Animal c, Food f)
        {
            c.Eat(f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OOP3;

namespace OOP3
{
    class Animal
        
    {
        
        public string name;
        public double weight;
        public int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void DoSound()
        {
            Console.WriteLine("Making lot of sound.");
        }
        public Animal(string animalName, double animalWeight, int animalAge)
        {
            name = animalName;
            weight = animalWeight;
            age = animalAge;
        }
        
     }
    class Horse : Animal
    {
        public int = 23;
    }
    
    
       
 } 

        

        //Horse , Dog , Hedgehog , Worm och Bird, Wolf .


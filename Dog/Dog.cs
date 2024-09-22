using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    public class Dog
    {
        private string breed;
        private string name;
        private int age;
        private string ownerName;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public Dog(string breed, string name, int age, string ownerName)
        {
            this.Breed = breed;
            this.Name = name;
            this.Age = age;
            this.OwnerName = ownerName;
        }

        public override string ToString()
        {
            return $"Bred: {this.Breed}, Name:{this.Name}, Age: {this.Age}, Owner: {this.OwnerName}";
        }
    }
}

using System;
namespace Projeto19.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        //construtores
        public Department() 
        { 
        }

        public Department(string name)
        {
            Name = name;
        }
    }  
}

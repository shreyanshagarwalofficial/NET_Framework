using System;

namespace Assignment_3
{
    class Stud
    {
        public string Name;

        public Stud(string name)
        {
            Name = name;
        }
    }

    class Employee
    {
        public string Name;
        public Employee(string name)
        {
            Name = name;
        }
    }

    class Repository<T>
    {
        T item;

        public void Store(T obj)
        {
            item = obj;
        }

        public T Get()
        {
            return item;
        }
    }

    class Repository
    {
        static void Main16(string[] args)
        {
            Stud ob = new Stud("Surya");
            Employee ob1 = new Employee("Piyush");
            Repository<Stud> studentRepo = new Repository<Stud>();
            studentRepo.Store(ob);
            Repository<Employee> employeeRepo = new Repository<Employee>();
            employeeRepo.Store(ob1);
            Console.WriteLine("Student:" + studentRepo.Get().Name);
            Console.WriteLine("Employee:" + employeeRepo.Get().Name);
        }
    }
}
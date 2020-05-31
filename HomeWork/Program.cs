using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using Model;



namespace HomeWork
{
    class Program
    {

        List<Model.Worker> employees = new List<Model.Worker>
            {
                new Model.Worker() {name = "Marian", surname = "Kowalski", department = "IT", pass = null},
                new Model.Worker() {name = "Paweł", surname = "Nowak", department = "HR", pass = null},
                new Model.Worker() {name = "Piotr", surname = "Mandel", department = "IT", pass = null},
                new Model.Worker() {name = "Lucjan", surname = "Oruno", department = "LG", pass = null},
                new Model.Worker() {name = "Rafał", surname = "Lipski", department = "HR", pass = null},
                new Model.Worker() {name = "Marek", surname = "Mateja", department = "IT", pass = null},
                new Model.Worker() {name = "Katarzyna", surname = "Sama", department = "LG", pass = null}
            };

        public void GetWorkersFromItOrHrDepartment()
        {
            var workersFromHrOrIt = from worker in employees
                                    where worker.department == "IT" || worker.department == "HR"
                                    select worker;

            foreach (var worker in workersFromHrOrIt)
            {
                Console.WriteLine("Pracownik działu IT lub HR to: " + $"{worker.surname}");
            }

        }
        public void SetRandomPassForAllEmployees()
        {
             

            foreach (var worker in employees)
            {
                Guid randomPasswd = Guid.NewGuid();
                worker.pass = randomPasswd.ToString();

                Console.WriteLine("Hasło użytkownika " + $"{worker.surname}" + " to " + $"{worker.pass}");
            }
        }
        public void GetOrderedListWithSurnames()
        {
            var orderedEmployees = from worker in employees
                                   orderby worker.surname ascending
                                   select worker;

            foreach (var worker in orderedEmployees)
            {
                Console.WriteLine($"{worker.surname}");
            }
        }
        static void Main(string[] args)
        {

            Program program = new Program();
            


            program.GetOrderedListWithSurnames();
            program.SetRandomPassForAllEmployees();
            program.GetWorkersFromItOrHrDepartment();



            Console.Read();

        }

        
    }

}

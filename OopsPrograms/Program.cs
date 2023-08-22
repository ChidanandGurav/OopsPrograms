using OopsPrograms.Inheritance;
using OopsPrograms.Partial_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* //Date

             //create a object of class
            Date dateobj1 = new Date();
             //call method
            dateobj1.AcceptDate(4, "August", 2023); // method call

            string res = dateobj1.PrintDate();
             Console.WriteLine(res);

//________________________________________________________________________________________________________

             //Student

            Student s = new Student();
             s.AcceptDetails(01, "tanuja", 101, "comp", 90, 82, 92);
            s.calculate();
             Console.WriteLine(s.PrintDetails());
             s.grade();

             Student std = new Student();
             Student std1 = new Student(1, 12, "Rahul", "Mech", 65.25);
             Student std2 = new Student(1, 10, "Omkar", "E&C", 75.25);


             Console.WriteLine(std1.PrintDetails());
             Console.WriteLine(std2.PrintDetails());

//________________________________________________________________________________________________________

             // Employee

            Employee empobj3 = new Employee();
             empobj3.AcceptEmployee(2, "Darshan Patil", 25 , 23000);
             empobj3.CalculatSalary();
             Console.WriteLine(empobj3.Print());

             Employee employee = new Employee();
             Employee employee1= new Employee("Suresh",25,23500);
             Employee employee2= new Employee("Ram",35,50000);
             Employee employee3 = new Employee("Shubham", 35, 20000);

             employee1.CalculatSalary();
             employee2.CalculatSalary();
             employee3.CalculatSalary();

             Console.WriteLine(employee1.Print());
             Console.WriteLine(employee2.Print());
             Console.WriteLine(employee3.Print());

             Console.WriteLine("Total Employee is " + Employee.GetempCount()); // Static method (Using Class Name)

//__________________________________________________________________________________________________________

             //Books

             Books bkobj4 = new Books();
             bkobj4.AcceptBooks(5, "Shivaji Maharaj", 156.32);
            string BK = bkobj4.PrintBooks();
             Console.WriteLine(BK);

             Books bk= new Books();
             Books bk1= new Books(2 , "Bhagavtgeeta" , 500.23);
             Books bk2= new Books(8 , "Ramayan" , 250.2);

             Console.WriteLine(bk1.PrintBooks());
             Console.WriteLine(bk2.PrintBooks());

//______________________________________________________________________________________________________________

             // Account

             Account Accobj = new Account();
             Accobj.AcceptAccount(586532512, "Saving Account", 50000.56);
              Console.WriteLine(Accobj.show());
              Accobj.Withdrow();
              Accobj.Diposite();

//_________________________________________________________________________________________________________

             //Bank

             Bank b1 = new Bank(121212 , "Onkar" , 10000);
             Console.WriteLine(b1.PrintBalance());
             b1.Creadit(5000);
             Console.WriteLine(b1.PrintBalance());

            string msg =  b1.Debit(16000);
             Console.WriteLine(msg);
             Console.WriteLine(b1.PrintBalance());

//____________________________________________________________________________________________________________

             // Product

             Product p1 = new Product(1, "Soap", 100);
             Console.WriteLine(p1.Discount(10));

//___________________________________________________________________________________________________________
 */

            /*// StudentProperty

            // Property initializer syntax 
            StudentProperty std = new StudentProperty(); 
            //set accessor
            std.RollNo = 1;
            std.Name = "Onkar";
            std.Percentage = 56;

            //get accessor
            Console.WriteLine($"{std.RollNo} {std.Name} {std.Percentage}");
            Console.WriteLine(std.Print());

            // object initiazlier syntax
            StudentProperty std1= new StudentProperty() { RollNo = 2, Name = "Akash", Percentage = 90 };
            Console.WriteLine($"{std1.RollNo} {std1.Name} {std1.Percentage}");
*/
            //______________________________________________________________________________________________________________

            // ProductProperty
            /*// Property initializer syntax 
            ProductProperty p1 = new ProductProperty();
            //set accessor
            p1.Code= 1;
            p1.Name = "Soap";
            p1.Price= 100;

            // get accessor
            Console.WriteLine($"{p1.Code} {p1.Name} {p1.Price}");
            Console.WriteLine(p1.Print());

            // object initiazlier syntax
            ProductProperty p2 = new ProductProperty() { Code = 2, Name = "Brush", Price = 25 };
            Console.WriteLine($"{p2.Code} {p2.Name} {p2.Price}");
*/
            //_______________________________________________________________________________________________________________

            // Movie

            /*  Movie m1 = new Movie(1, "URI", 200, 15);
              m1.Dispaly();
              m1.FindAvailable();
              m1.Details();*/

            //_____________________________________________________________________________________________________________

            // Method Overloading

            /* MethodOverloading_Calculation c = new MethodOverloading_Calculation();
             Console.WriteLine(c.Addition(2, 2));
             Console.WriteLine(c.Addition(25 , 30));
             Console.WriteLine(c.Addition(1,29));
             Console.WriteLine(c.Addition(2, 8, 1));*/

            //_____________________________________________________________________________________________________________

            // NameArgument

            // parameter list or argument list
            /*NameArgument_Car c1 = new NameArgument_Car("i10", 890000);

            NameArgument_Car c2 = new NameArgument_Car(companyname: "i20", cost: 450000);//named argument

            NameArgument_Car c3 = new NameArgument_Car(cost: 350000, companyname: "hundai");

            // ___________________________________________________________________________________________________

            // Default parameter and Optional

            // companyname parameter is optional
            DefaultOptional_Car c4 = new DefaultOptional_Car("i20", 670000);

            // if you pass the parameter then value will be modified for companyname
            // c4 = new DefaultOptional_Car("Ameze", 7700000, "Honda");

            Console.WriteLine(c4.Print());*/

            //_____________________________________________________________________________________________________________

            // Inheritence parent and child class

            /*Manager m1 = new Manager(2000, "Rohit", 35, 35000);
            m1.CalculatSalary();
            Console.WriteLine(m1.Print());
     

            Employee e1 = new Employee("Omkar", 25, 22000);
            e1.CalculatSalary();
            Console.WriteLine(e1.Print());

            Employee e2 = new Manager(1500, "Nikhi", 28, 32000);
            e2.CalculatSalary(); //it is call Manager salary    
            Console.WriteLine(e2.Print());*/

            //____________________________________________________________________________________________________________

            //Person and  patient

            /* Person p1 = new Person(234567891 , "Ram" , "Karve Nagar");
             Console.WriteLine(p1.Print());

             Person p2 = new Patient("B+ve", 200, 1256348792, "Hari", "Warje");
             Console.WriteLine(p2.Print());*/

            //_____________________________________________________________________________________________________________________________

            //From the existing Employee class create new child class called SalesEmployee
            // &implement the inheritance(bonus+comm) &polymorphism(method overriding)

            /*EmployeeOverriding e = new EmployeeOverriding(1, "Sham", 15000);
            e.Cal_Salary();
            Console.WriteLine(e.Print());

            EmployeeOverriding e2 = new SalesEmployee(2, "Ram", 2500, 1500, 15000);
            e2.Cal_Salary();
            Console.WriteLine(e2.Print());*/

            //______________________________________________________________________________________________________________________

            // Area of sq,tri,renctan

            /* Area_Overload a = new Area_Overload();
             a.area(5.0);
             Console.WriteLine(a.Display());

             Area_Overload s = new Area_Overload();
             s.area(8);
             Console.WriteLine(s.Display());

             Area_Overload re = new Area_Overload();
             re.area(2.0 , 3.0);
             Console.WriteLine(re.Display());

             Area_Overload t = new Area_Overload();
             t.area(5.5f , 8);
             Console.WriteLine(t.Display());*/

            //_____________________________________________________________________________________________________________________

            // Abstract Class

            /*Rectangular r1 = new Rectangular(4.0, 5.0);
            r1.Area();
            Console.WriteLine(r1.print());


            Circle c1 = new Circle(3.14 , 2 , 2);
            c1.Area();
            Console.WriteLine(r1.print());
*/
            //______________________________________________________________________________________________________________________________


            // Interface

            /* Employee1 e = new Employee1();
              e.Print();

              Manager1 m = new Manager1();
              m.Print();

              Student1 s = new Student1();
              s.Print();*/

            //______________________________________________________________________________________________________________________________


            /*ObjectCount o1 = new ObjectCount("shree");
            ObjectCount o2 = new ObjectCount("Ram");
            Console.WriteLine(ObjectCount.Objects());*/

            //______________________________________________________________________________________________________________________________


            // Excplicit Implimentation


            /* Icustomer c1 = new Transaction();
             Console.WriteLine(c1.Display());

             Iorders o1 = new Transaction();
             Console.WriteLine(o1.Display());*/

            /*IStudent s = new Display();
            Console.WriteLine(s.Display());

            IMarks m = new Display();
            Console.WriteLine(m.Display());*/

            //_______________________________________________________________________________________________________________________________

            // Partial Class

            /*Calc c1 = new Calc();
            Console.WriteLine(c1.Square(5));*/
            //_____________________________________________________________________________________________________________________________

            /*  Emp e1 = new Man( 100, "Akash", 20300);
              Console.WriteLine(e1.Print());*/
            //_______________________________________________________________________________________________________________________________

            





        }
    }
}

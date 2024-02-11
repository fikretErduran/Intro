// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");


String mesaage1 = "krediler";
int term = 12;
double amount = 100000.5;

bool isAuthenticated = true;
Console.WriteLine(mesaage1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Button--> Hoş Geldiniz Fikret");
}
else
{
    Console.WriteLine("Button--> Sisteme giriş yap");
}
Console.WriteLine("----------------------------------------------");

String [] loans = {"kredi1","kredi2","kredi3","kredi4","kredi5","kredi6" };

//String [] loans2 = new string []
//{
//   "Kredi1","kredi2","kredi3","kredi4","kredi5"
//};

//String [] loans3 = new string [3];
//loans3[0] = "kredi1";
//loans3[1] = "kreid2";
//loans3[2] = "kredi3";
//loans3[3] = "kredi4";


      //start  // condition   // increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}
Console.WriteLine("----------------------------------------------");



    CourseManeger courseManeger= new CourseManeger();
    Course[] courses2 = courseManeger.GetAll();
   
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].CourseId + " " + courses2[i].CourseName + " " + courses2[i].CourseDescription + " " +
        courses2[i].CoursePrice + " " + "TL");

}

Console.WriteLine("Kod Bitti");


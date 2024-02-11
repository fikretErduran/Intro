using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public  class CourseManeger
{
    Course[] courses=new Course[3];
    public CourseManeger()
    {
        Course course1 = new Course();
        course1.CourseId = 1;
        course1.CourseName = "C# Yazılım Geliştirme";
        course1.CourseDescription = "Nesne tabanlı uygulamar ve dongu - sart blokları gibi eğitimler";
        course1.CoursePrice = 1000;

        Course course2 = new Course();
        course2.CourseId = 2;
        course2.CourseName = "Java Yazılım Geliştirme";
        course2.CourseDescription = "Nesne tabanlı uygulamar ve dongu - sart blokları gibi eğitimler";
        course2.CoursePrice = 1500;

        Course course3 = new Course();
        course3.CourseId = 3;
        course3.CourseName = "Pyhton Yazılım Geliştirme ";
        course3.CourseDescription = "Nesne tabanlı uygulamar ve dongu - sart blokları gibi eğitimler";
        course3.CoursePrice = 2000;

        courses[0]=course1;
        courses[1]=course2;
        courses[2]=course3;

    }
    public Course[]  GetAll()
    {
        return courses;
    }
}

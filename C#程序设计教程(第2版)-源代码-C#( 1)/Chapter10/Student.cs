using System;
namespace CSharpBook.Chapter10 
{
  struct Student    //Student结构
  {
    public struct Grade    //嵌套结构（分数）
    {
        public string courseName; public float courseGrade;//课程名称、分数
        public Grade(string name, float grade)  //嵌套结构的构造函数
        {
            courseName = name;  courseGrade = grade;
        }
    }
    public string studentID, studentName;  //学生学号、姓名
    public Grade[] grades;              //分数（嵌套结构类型）
    public Student(string id, string name)  //学生结构的构造函数
    {
        studentID = id; studentName = name; grades = new Grade[3];
    }
  }
  class TestClass
  {
    static void Main()
    {
        Student s1 = new Student("200910101", "zhangsan");
        s1.grades = new Student.Grade[] { new Student.Grade("语文", 80),
             new Student.Grade("数学", 90), new Student.Grade("英语", 100) };
        Console.WriteLine("Student ID={0}, Student Name={1}",s1.studentID,s1.studentName);
        foreach (Student.Grade g in s1.grades)
        {
          Console.WriteLine("Course={0}, Grade={1}", g.courseName, g.courseGrade);
        }
        Console.ReadLine();
    }
}
}

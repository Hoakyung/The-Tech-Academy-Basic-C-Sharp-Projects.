using Students;

using (StudentContext db = new StudentContext())
{
    Student student = new Student();
    student.StudentName = "Mary";

    db.Students.Add(student);
    db.SaveChanges();

    Console.WriteLine("Student added successfully!");
}
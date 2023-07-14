var list = new List<Student>();

var st1 = new Student()
{
    FullName = "Aminjon Amirov",
    Grade = 11,
    Scores = new double[5] {90, 50, 70, 100, 100}
};

var st2 = new Student()
{
    FullName = "Aminjon Abdulloev",
    Grade = 10,
    Scores = new double[5] {100, 90, 90, 100, 100}
};

var st3 = new Student()
{
    FullName = "Shahrom Sultonalizoda",
    Grade = 11,
    Scores = new double[5] {100, 100, 100, 100, 100}
};

var st4 = new Student()
{
    FullName = "Test Testov",
    Grade = 1,
    Scores = new double[5] {30, 40, 50, 60, 70}
};

var st5 = new Student()
{
    FullName = "Ivan Ivanov",
    Grade = 2,
    Scores = new double[5] {100, 90, 80, 70, 60}
};

list.Add(st1);
list.Add(st2);
list.Add(st3);
list.Add(st4);
list.Add(st5);

foreach (var item in list)
{
    if ( item.Average() > 85 )
    {
        System.Console.WriteLine($"Congratulations {item.FullName} on achieving above average scores ({item.Average()}) in grade {item.Grade}! Keep up the good work!");
    }
}
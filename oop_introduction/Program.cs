//List<int> numbers = new List<int>();
//numbers.Add(item: 0);
//numbers.Add(item: 1);
//numbers.Add(item: 2);
//numbers.Add(item: 3);
//numbers.Add(item: 4);
//numbers.Add(item: 5);
//numbers.Add(item: 6);
//numbers.Add(item: 7);
//numbers.Add(item: 8);


//idk proc to olzbut neudelal foreachem
//for(int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//foreach (var index in numbers)
//{
//    Console.WriteLine(numbers[index]);
//}


using oop_introduction;

Skewl sk1 = new Skewl()
{
    name = "SPS-PROSEK"
};

sk1.students.Add(item: new Student()
{
    name = "Mike",
    surname = "Oxlong",
    personal_id_num = 2000
});
sk1.students.Add(item: new Student()
{
    name = "Hugh",
    surname = "Jass",
    personal_id_num = 2000
});

Subject sub1 = new Subject()
{
    name = "App development",
    abbreviation = "VA"
};

sk1.students[0].grades.Add(item: new Grade()
{
    value = 1,
    weight = 30,
    subject = sub1,
});

sk1.students[1].grades.Add(item: new Grade()
{
    value = 2,
    weight = 30,
    subject = sub1,
});

Console.WriteLine(sk1.AvgStudentMark());
Console.WriteLine(sk1.AvgStudentMarkAccToSubject(sub1));


Console.ReadKey();


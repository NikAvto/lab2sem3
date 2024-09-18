using System.Runtime.CompilerServices;

public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Ученик учится");
    }
    public virtual void Read()
    {
        Console.WriteLine("Ученик читает");
    }
    public virtual void Write() 
    {
        Console.WriteLine("Ученик пишет");
    }
    public virtual void Relax()
    {
        Console.WriteLine("Ученик отдыхает");
    }
}
public class ExcellentPupil : Pupil  
{
    public override void Study()
    {
        Console.WriteLine("Отличник учится");
    }
    public override void Read()
    {
        Console.WriteLine("Отличник читает");
    }
    public override void Write()
    {
        Console.WriteLine("Отличник пишет");
    }
    public override void Relax()
    {
        Console.WriteLine("Отличник отдыхает");
    }
}
public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Хорошист учится");
    }
    public override void Read()
    {
        Console.WriteLine("Хорошист читает");
    }
    public override void Write()
    {
        Console.WriteLine("Хорошист пишет");
    }
    public override void Relax()
    {
        Console.WriteLine("Хорошист отдыхает");
    }
}
public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Двоечник учится");
    }
    public override void Read()
    {
        Console.WriteLine("Двоечник читает");
    }
    public override void Write()
    {
        Console.WriteLine("Двоечник пишет");
    }
    public override void Relax()
    {
        Console.WriteLine("Двоечник отдыхает");
    }
}

public class Classroom
{
    public Pupil[] pupils;
    public Classroom(params Pupil[] pupils)
    {
        this.pupils = new Pupil[pupils.Length];
        for (int i = 0; i < pupils.Length; ++i)
        {
            this.pupils[i] = pupils[i];
        }
    }
    public void ShowPupilsSkills()
    {
        foreach(var pupil in pupils)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}
//Классы для задания 2
public class vehicle
{
    public int x, y, z;
    public float cost, speed;
    public string year;
    public vehicle(int x, int y, int z, float cost, float speed, string year) { this.x = x; this.y = y; this.z = z; this.cost = cost; this.speed = speed; this.year = year; }
    public virtual void Print()
    {
        Console.WriteLine($"Координаты: {x}, {y}, {z}");
        Console.WriteLine($"Цена: {cost}");
        Console.WriteLine($"Скорость: {speed}");
        Console.WriteLine($"Год выпуска: {year}");
    }
}
public class Plane : vehicle
{
    public int height;
    public int passangers_count;
    public Plane(int x, int y, int z, float cost, float speed, string year, int height, int passangers_count) : base(x, y, z, cost, speed, year) { this.height = height; this.passangers_count = passangers_count; }
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Высота полёта: {height}");
        Console.WriteLine($"Количество пассажиров: {passangers_count}");
    }
}

public class Ship : vehicle
{
    public string port;
    public int passangers_count;
    public Ship(int x, int y, int z, float cost, float speed, string year, string port, int passangers_count) : base(x, y, z, cost, speed, year) { this.port = port; this.passangers_count = passangers_count; }
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Приписанный порт: {port}");
        Console.WriteLine($"Количество пассажиров: {passangers_count}");
    }
}

public class Car : vehicle
{
    public Car(int x, int y, int z, float cost, float speed, string year) : base(x, y, z, cost, speed, year) { }
}
//Классы для задания 3
public class DocumentWorker
{
    public virtual void OpenDocument() { Console.WriteLine("Документ открыт"); }
    public virtual void EditDocument() { Console.WriteLine("Редактирование доступно в версии Pro"); }
    public virtual void SaveDocument() { Console.WriteLine("Сохранение доступно в версии Pro"); }
}

public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument() { Console.WriteLine("Документ отредактирован"); }
    public override void SaveDocument() { Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert"); }
}

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}
class progoram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задание 1:");
        Pupil a = new Pupil();
        GoodPupil b = new GoodPupil();
        ExcellentPupil c = new ExcellentPupil();
        BadPupil d = new BadPupil();
        Classroom cr = new Classroom(a,b,c,d);
        cr.ShowPupilsSkills();
        Console.WriteLine();
        Console.WriteLine("\nЗадание 2:");
        vehicle v = new vehicle(1, 1, 1, 1000000, 200, "2009");
        Ship s = new Ship(1, 1, 1, 10000000, 120, "2020", "south port", 10000);
        Plane p = new Plane(1, 1, 1, 10000000, 500, "2017", 100000, 40);
        v.Print();
        Console.WriteLine();
        s.Print();
        Console.WriteLine();
        p.Print();
        Console.WriteLine();
        Console.WriteLine("Задание 3:");
        Console.WriteLine("Введите ключ: "); string key = Console.ReadLine();
        if (key == "pro")
        {
            ProDocumentWorker doc = new ProDocumentWorker();
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();
        }
        else if (key == "exp")
        {
            ExpertDocumentWorker doc2 = new ExpertDocumentWorker();
            doc2.OpenDocument();
            doc2.EditDocument();
            doc2.SaveDocument();
        }
        else
        {
            DocumentWorker doc3 = new DocumentWorker();
            doc3.OpenDocument();
            doc3.EditDocument();
            doc3.SaveDocument();
        }
    }
}
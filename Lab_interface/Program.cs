using System;
using System.Diagnostics;

// Завдання 1.2: Менеджер завдань

// Інтерфейс ITask
public interface ITask
{
    void Start();
    void Complete();
    string GetTaskInfo();
}

// Клас WorkTask
class WorkTask : ITask
{
    private string title;
    private string description;
    private DateTime dueDate;

    public WorkTask(string title, string description, DateTime dueDate)
    {
        this.title = title;
        this.description = description;
        this.dueDate = dueDate;
    }

    public void Start()
    {
        Console.WriteLine("Початок виконання завдання \"{0}\".", this.title);
    }

    public void Complete()
    {
        Console.WriteLine("Завдання \"{0}\" виконано.", this.title);
    }

    public string GetTaskInfo()
    {
        return $"Заголовок: {this.title}\nОпис: {this.description}\nТермін виконання: {this.dueDate}";
    }
}

class PersonalTask : ITask
{
    private string title;
    private string description;

    public PersonalTask(string title, string description)
    {
        this.title = title;
        this.description = description;
    }

    public void Start()
    {
        Console.WriteLine("Початок виконання завдання \"{0}\".", this.title);
    }

    public void Complete()
    {
        Console.WriteLine("Завдання \"{0}\" виконано.", this.title);
    }

    public string GetTaskInfo()
    {
        return $"Заголовок: {this.title}\nОпис: {this.description}";
    }
}

class StudyTask : ITask
{
    private string title;
    private string subject;
    private int hoursToComplete;

    public StudyTask(string title, string subject, int hoursToComplete)
    {
        this.title = title;
        this.subject = subject;
        this.hoursToComplete = hoursToComplete;
    }

    public void Start()
    {
        Console.WriteLine("Початок виконання завдання \"{0}\".", this.title);
    }

    public void Complete()
    {
        Console.WriteLine("Завдання \"{0}\" виконано.", this.title);
    }

    public string GetTaskInfo()
    {
        return $"Заголовок: {this.title}\nПредмет: {this.subject}\nЧас виконання: {this.hoursToComplete} годин";
    }
}

// Тестування
public partial class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів різних типів завдань
        WorkTask workTask = new WorkTask("Написати код для нового додатка", "Написати код для нового додатка, який буде виконувати певну задачу.", new DateTime(2023, 12, 20));
        PersonalTask personalTask = new PersonalTask("Прибратися вдома", "Прибратися вдома, щоб було чисто і затишно.");
        StudyTask studyTask = new StudyTask("Вивчити тему \"Машинне навчання\"", "Вивчити тему \"Машинне навчання\" для здачі іспиту.", 10);

        // Виклик різних методів
        workTask.Start();
        personalTask.Complete();
        studyTask.GetTaskInfo();
    }
}


// Завдання 2.2: Музичний програвач

// Інтерфейс IPlayable
public interface IPlayable
{
    void Play();
    void Pause();
    void Stop();
}

// Інтерфейс IRecordable
public interface IRecordable
{
    void Record();
}

// Клас MusicTrack
public class MusicTrack : IPlayable, IRecordable
{
    public string TrackName { get; set; }
    public string Artist { get; set; }
    public double Duration { get; set; }

    public void Play()
    {
        Console.WriteLine($"Playing '{TrackName}' by {Artist} ({Duration} seconds).");
    }

    public void Pause()
    {
        Console.WriteLine($"Pausing '{TrackName}'.");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopping '{TrackName}'.");
    }

    public void Record()
    {
        Console.WriteLine($"Recording '{TrackName}' by {Artist}.");
    }
}

// Тестування


// Завдання 3: Електронний пристрій інтернет-магазину

// Інтерфейс IProduct
public interface IProduct
{
    void DisplayInfo();
}

// Інтерфейс IShoppable
public interface IShoppable
{
    void AddToCart();
}

// Клас ElectronicDevice
public class ElectronicDevice : IProduct
{
    public string DeviceName { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Electronic Device: {DeviceName} ({Manufacturer}), Price: {Price:C}");
    }
}

// Клас Smartphone
public class Smartphone : ElectronicDevice, IShoppable
{
    public string OperatingSystem { get; set; }

    public void AddToCart()
    {
        Console.WriteLine($"Adding {DeviceName} to the shopping cart.");
    }
}

// Клас Laptop
public class Laptop : ElectronicDevice, IShoppable
{
    public string Processor { get; set; }

    public void AddToCart()
    {
        Console.WriteLine($"Adding {DeviceName} to the shopping cart.");
    }
}

// Тестування

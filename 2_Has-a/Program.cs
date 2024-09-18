using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Performer worker1 = new Performer("Артём");
        Performer worker2 = new Performer("Игорь");

        Task[] tasks = { new Task(worker1, "Создать БД"), new Task(worker2, "Составить схему")};

        Board schedule = new Board(tasks);

        schedule.ShowAllTasks();
    }
}

class Performer
{
    public string Name;

    public Performer(string name)
    {
        Name = name;
    }
}

class Board
{
    public Task[] Tasks;

    public Board(Task[] tasks)
    {
        Tasks = tasks;
    }

    public void ShowAllTasks()
    {
        for (int i = 0; i < Tasks.Length; i++)
        {
            Tasks[i].ShowInfo();
        }
    }
}

class Task
{
    public Performer Worker;
    public string Description;

    public Task(Performer worker, string description)
    {
        Worker = worker;
        Description = description;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Ответственный: {Worker.Name}\nОписание задачи: {Description}.\ns");
    }
}

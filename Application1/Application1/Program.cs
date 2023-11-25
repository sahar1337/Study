namespace Application1;

using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
}

class Program
{
    private static List<Task> tasks = new List<Task>();
    private static string jsonFilePath = "tasks.json";

    public static void Main()
{
    LoadTasksFromJson();

    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Добавить задачу");
    Console.WriteLine("2. Удалить задачу");
    Console.WriteLine("3. Редактировать задачу");
    Console.WriteLine("4. Просмотреть задачи на сегодня");
    Console.WriteLine("5. Просмотреть просроченные задачи");
    Console.WriteLine("6. Просмотреть все задачи");

    string choice = Console.ReadLine();

    string newTitle;
    string newDescription;
    DateTime newDueDate;
    switch (choice)
    {
        case "1":
            Console.WriteLine("Введите название задачи:");
            newTitle = Console.ReadLine();
            Console.WriteLine("Введите описание задачи:");
            newDescription = Console.ReadLine();
            Console.WriteLine("Введите дату завершения задачи в формате (гггг, мм, дд):");
            newDueDate = DateTime.Parse(Console.ReadLine());
            AddTask(newTitle, newDescription, newDueDate);
            break;
        case "2":
            Console.WriteLine("Введите название задачи для удаления:");
            string taskToRemove = Console.ReadLine();
            RemoveTask(taskToRemove);
            break;
        case "3":
            Console.WriteLine("Введите название задачи для редактирования:");
            string taskToEdit = Console.ReadLine();
            Console.WriteLine("Введите новое описание задачи:");
            newDescription = Console.ReadLine();
            Console.WriteLine("Введите новую дату завершения задачи в формате (гггг, мм, дд):");
            newDueDate = DateTime.Parse(Console.ReadLine());
            EditTask(taskToEdit, newDescription, newDueDate);
            break;
        case "4":
            ViewTasksForToday();
            break;
        case "5":
            ViewOverdueTasks();
            break;
        case "6":
            ViewAllTasks();
            break;
        default:
            Console.WriteLine("Некорректный выбор");
            break;
    }

    SaveTasksToJson();
}

    static void AddTask(string title, string description, DateTime dueDate)
    {
        Task newTask = new Task { Title = title, Description = description, DueDate = dueDate };
        tasks.Add(newTask);
    }

    static void RemoveTask(string title)
    {
        Task taskToRemove = tasks.Find(t => t.Title == title);
        if (taskToRemove != null)
        {
            tasks.Remove(taskToRemove);
        }
    }

    static void EditTask(string title, string newDescription, DateTime newDueDate)
    {
        Task taskToEdit = tasks.Find(t => t.Title == title);
        if (taskToEdit != null)
        {
            taskToEdit.Description = newDescription;
            taskToEdit.DueDate = newDueDate;
        }
    }

    static void ViewTasksForToday()
    {
        DateTime today = DateTime.Today;
        var tasksForToday = tasks.FindAll(t => t.DueDate.Date == today);
        foreach (var task in tasksForToday)
        {
            Console.WriteLine($"Название: {task.Title}, Описание: {task.Description}, Дата: {task.DueDate}");
        }
    }
    
    static void ViewOverdueTasks()
    {
        Console.WriteLine("Просроченные задачи:");

        DateTime today = DateTime.Today;

        foreach (var task in tasks)
        {
            if (task.DueDate < today)
            {
                Console.WriteLine($"Название: {task.Title}, Описание: {task.Description}, Дата завершения: {task.DueDate}");
            }
        }
    }

    static void ViewAllTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"Название: {task.Title}, Описание: {task.Description}, Дата: {task.DueDate}");
        }
    }

    static void SaveTasksToJson()
    {
        using (StreamWriter file = File.CreateText(jsonFilePath))
        {
            var serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.Serialize(file, tasks);
        }
    }

    static void LoadTasksFromJson()
    {
        if (File.Exists(jsonFilePath))
        {
            using (StreamReader file = File.OpenText(jsonFilePath))
            {
                var serializer = new Newtonsoft.Json.JsonSerializer();
                tasks = (List<Task>)serializer.Deserialize(file, typeof(List<Task>));
            }
        }
    }
}
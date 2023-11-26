using System;
using System.Collections.Generic;

// Завдання 1

class Task
{
    public int TaskId { get; set; }
    public string Description { get; set; }
}

class TaskManager
{
    private List<Task> taskList;

    public TaskManager()
    {
        taskList = new List<Task>();
    }

    public void AddTask(Task task)
    {
        taskList.Add(task);
    }

    public void RemoveTask(int taskId)
    {
        Task taskToRemove = taskList.Find(task => task.TaskId == taskId);
        if (taskToRemove != null)
            taskList.Remove(taskToRemove);
    }

    public void DisplayTasks()
    {
        Console.WriteLine("Tasks:");
        foreach (var task in taskList)
        {
            Console.WriteLine($"TaskId: {task.TaskId}, Description: {task.Description}");
        }
    }
}

// Завдання 2

class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class UserManager
{
    private List<User> userList;

    public UserManager()
    {
        userList = new List<User>();
    }

    public void AddUser(User user)
    {
        userList.Add(user);
    }

    public void RemoveUser(int userId)
    {
        User userToRemove = userList.Find(user => user.Id == userId);
        if (userToRemove != null)
            userList.Remove(userToRemove);
    }

    public User FindUserById(int userId)
    {
        return userList.Find(user => user.Id == userId);
    }

    public void DisplayUsers()
    {
        Console.WriteLine("Users:");
        foreach (var user in userList)
        {
            Console.WriteLine($"UserId: {user.Id}, Name: {user.Name}");
        }
    }

    internal User GetUserById(int v)
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {

        // Тестування завдання 1
        TaskManager taskManager = new TaskManager();
        taskManager.AddTask(new Task { TaskId = 1, Description = "Complete assignment" });
        taskManager.AddTask(new Task { TaskId = 2, Description = "Submit report" });
        taskManager.DisplayTasks();
        taskManager.RemoveTask(1);
        taskManager.DisplayTasks();

        // Тестування завдання 2
        UserManager userManager = new UserManager();
        userManager.AddUser(new User { Id = 1, Name = "Igor Vinnychuk" });
        userManager.AddUser(new User { Id = 2, Name = "Igor Stanislavovich" });
        userManager.DisplayUsers();
        userManager.RemoveUser(1);
        userManager.DisplayUsers();
        User foundUser = userManager.GetUserById(2);
        if (foundUser != null)
        {
            Console.WriteLine($"Found user: UserId: {foundUser.Id}, Name: {foundUser.Name}");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }
}

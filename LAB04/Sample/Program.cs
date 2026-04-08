using OOP_COLLECTIONS;
using System;

class Program
{
    static void Main(string[] args)
    {
        // =========================
        // 1. Cоздать отдел с названием "IT"
        // =========================
        Department itDept = new Department("IT");

        // =========================
        // 2. Cоздать 2-х рабочих
        // =========================
        Worker worker1 = new Worker("Сергей", 1200, 25); // 5 смен сверх нормы (бонус 250)
        Worker worker2 = new Worker("Яна", 1100, 18); // Смен меньше 20 (без бонуса)

        // =========================
        // 3. Cоздать 2-х программистов
        // =========================
        Programmer prog1 = new Programmer("Артём", 2500, "Middle"); // Бонус 600
        Programmer prog2 = new Programmer("Виктория", 4000, "Lead"); // Бонус 1500

        // =========================
        // 4. Cоздать 1-го менеджера
        // =========================
        Manager manager1 = new Manager("Николай", 3500, 8); // Бонус: 8 * 200 = 1600

        // =========================
        // 5. Добавить всех сотрудников в отдел
        // =========================
        itDept.AddEmployee(worker1);
        itDept.AddEmployee(worker2);
        itDept.AddEmployee(prog1);
        itDept.AddEmployee(prog2);
        itDept.AddEmployee(manager1);

        // =========================
        // 6. Вывести всех сотрудников отдела
        // =========================
        Console.WriteLine("=== Все сотрудники отдела ===");
        itDept.ShowAllEmployees();
        // =========================
        // 7. Найти сотрудников с Id 1, 3, 7 и вывести информацию о них
        // =========================
        Console.WriteLine("\n=== Тестируем поиск сотрудника ===");
        int[] idsToSearch = { 1, 3, 7 };

        foreach (int id in idsToSearch)
        {
            Employee found = itDept.FindEmployeeById(id);

            if (found != null)
            {
                Console.WriteLine($"--- Результат поиска для ID {id}: ---");
                found.DisplayInfo();
            }
            else
            {
                Console.WriteLine($"--- Сотрудник с ID {id} не найден ---");
            }
        }

        // =========================
        // 8. Удалить сотрудника с Id = 2
        // =========================
        Console.WriteLine("\n=== Тестируем удаление сотрудника ===");
        int idToRemove = 2;
        bool isRemoved = itDept.RemoveEmployeeById(idToRemove);

        if (isRemoved)
        {
            Console.WriteLine($"Сотрудник с ID {idToRemove} успешно удален из отдела.");
        }
        else
        {
            Console.WriteLine($"Ошибка: Сотрудник с ID {idToRemove} не найден, удаление невозможно.");
        }

        // =========================
        // 9. Вывести всех сотрудников отдела после удаления
        // =========================
        Console.WriteLine("\n=== После удаления ===");
        itDept.ShowAllEmployees();
        // =========================
        // 10. Вывести на экран сводную информацию об отделе
        // =========================
        Console.WriteLine("\n=== Статистика Отдела ===");
        itDept.GetDepartmentInfo();
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
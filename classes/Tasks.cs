namespace lab4.classes;

public class Tasks
{
    public static Student[] data;
    public static void Task1()
    {
        Console.WriteLine("\nBefore sort: \n");
        PrintArr(data);

        Sort.DoubleBubbleSort(data, data.Length);

        Console.WriteLine("\nAfter sort: \n");
        PrintArr(data);
    }

    public static void Task2()
    {
        Student stud3 = new("Petrenko", "Olena", 7.5, 3);
        Student stud4 = new("Shevchenko", "Andriy", 8.3, 2);
        Student stud5 = new("Bondar", "Svitlana", 6.9, 1);
        Student stud6 = new("Kovalenko", "Dmytro", 9.2, 4);
        Student stud7 = new("Melnyk", "Oksana", 5.5, 2);
        Student stud8 = new("Tkachenko", "Volodymyr", 8.7, 3);
        Student stud9 = new("Horobets", "Iryna", 7.1, 1);
        Student stud10 = new("Krivenko", "Oleksii", 6.4, 2);
        Student stud11 = new("Dovzhenko", "Mykola", 9.8, 4);
        Student stud12 = new("Rudenko", "Kateryna", 7.9, 3);
        
        Student[] studentsArr = {stud3, stud4, stud5, stud6, stud7, stud8, stud9, stud10, stud11, stud12};

        LinkedList<Student> students = new LinkedList<Student>(studentsArr);
        
        Console.WriteLine("\nBefore sort: \n");
        PrintLinkedList(students);

        Sort.DoubleBubbleSort(students);

        Console.WriteLine("\nAfter sort: \n");
        PrintLinkedList(students);

        
    }

    public static void Task3()
    {
        Console.WriteLine("\nBefore sort: \n");
        PrintArr(data);

        Sort.HeapSort(data, data.Length);
        
        Console.WriteLine("\nAfter sort: \n");
        PrintArr(data);
    }
    
    static void PrintArr<T>(T[] arr)
    {
        foreach (T element in arr)
        {
            Console.Write($"{element} \n");
        }
    }

    static void PrintLinkedList<T>(LinkedList<T> arr)
    {
        foreach (T element in arr)
        {
            Console.Write($"{element} \n");
        }
    }
}
public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);


        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following value and priority: Nilber (10), Clara(13), Wesley(5), Mota(1):
        // Expected Result: Clara, Nilber, Wesley, Mota
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Nilber", 10);
        priorityQueue.Enqueue("Clara", 13);
        priorityQueue.Enqueue("Wesley", 5);
        priorityQueue.Enqueue("Mota", 1);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());



        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following value and priority: Nilber (13), Clara(13), Wesley(5), Mota(1):
        // Expected Result: Nilber, Clara, Wesley, Mota
        Console.WriteLine("Test 2");

        priorityQueue.Enqueue("Nilber", 13);
        priorityQueue.Enqueue("Clara", 13);
        priorityQueue.Enqueue("Wesley", 5);
        priorityQueue.Enqueue("Mota", 1);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}
// Task 29
// Напишите программу, которая задаёт массив из 8 элементов, которые вводит пользователь,
// и выводит их на экран.

Console.WriteLine("----- Task 29 -----");
Console.WriteLine("Enter 8 numbers");

int[] readNumbers(int n) {
    int[] res = new int[n];

    for (int i = 0; i < n; i++) {
        string num = Console.ReadLine().Trim();

        int tmp;
        if (!int.TryParse(num, out tmp)) {
            Console.WriteLine("Error: cannot parse number");
            Environment.Exit(1);
        }

        res[i] = tmp;
    }

    return res;
}

void printIntArr(int[] arr) {
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++) {
        Console.Write(arr[i]);
        Console.Write(", ");
    }
    Console.Write(arr[arr.Length - 1]);

    Console.WriteLine("]");
}

void main() {
    int[] numbers = readNumbers(8);

    printIntArr(numbers);
}

main();

Console.WriteLine("------------------");
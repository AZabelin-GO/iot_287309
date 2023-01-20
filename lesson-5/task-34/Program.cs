// Task 34
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("----- Task 34 -----");
Console.WriteLine("Generating array...");

int[] genArr(int n, int min, int max) {
    int[] res = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++) {
        res[i] = rnd.Next(min, max);
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

int countEvenNumbersInArr(int[] arr) {
    int res = 0;

    for(int i = 0; i < arr.Length; i++) {
        if (arr[i] % 2 == 0) {
            res ++;
        }
    }

    return res;
}

void main() {
    int[] numbers = genArr(5, 100, 999);
    
    printIntArr(numbers);
    
    Console.WriteLine(countEvenNumbersInArr(numbers));
}

main();

Console.WriteLine("------------------");
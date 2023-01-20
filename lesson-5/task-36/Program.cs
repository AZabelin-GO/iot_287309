// Task 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("----- Task 36 -----");
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

int sumEvenNumbersInArr(int[] arr) {
    int res = 0;

    for(int i = 0; i < arr.Length; i++) {
        if (i % 2 != 0) {
            res += arr[i];
        }
    }

    return res;
}

void main() {
    int[] numbers = genArr(5, -100, 100);
    
    printIntArr(numbers);
    
    Console.WriteLine(sumEvenNumbersInArr(numbers));
}

main();

Console.WriteLine("------------------");
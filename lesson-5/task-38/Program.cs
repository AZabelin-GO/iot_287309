// Task 38
// Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("----- Task 38 -----");
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

int findArrMin(int[] arr) {
    int min = arr[0];

    for(int i = 0; i < arr.Length; i++) {
        if (min > arr[i]){
            min = arr[i];
        }
    }

    return min;
}

int findArrMax(int[] arr) {
    int max = arr[0];

    for(int i = 0; i < arr.Length; i++) {
        if (max < arr[i]){
            max = arr[i];
        }
    }

    return max;
}

void main() {
    int[] numbers = genArr(5, 0, 10);

    printIntArr(numbers);
    
    int min = findArrMin(numbers);
    int max = findArrMax(numbers);
    
    Console.WriteLine(max - min);
}

main();

Console.WriteLine("------------------");
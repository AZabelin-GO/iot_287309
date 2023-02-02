// Task 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("----- Task 60 -----");
Console.WriteLine("Generating array...");

int[,,] gen3DArr(int x, int y, int z) {
    Random rnd = new Random();
    int[,,] res = new int[x, y, z];

    for (int i = 0; i < res.GetLength(0); i++) {
        for (int j = 0; j < res.GetLength(1); j++) {
            for (int k = 0; k < res.GetLength(2); k++) {
                int num = rnd.Next(10, 99);
                while (isNumInArr(res, num)) {
                    num = rnd.Next(10, 100);
                }

                res[i, j, k] = num;
            }
        }
    }

    return res;
}

bool isNumInArr(int[,,] arr, int num) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            for (int k = 0; k < arr.GetLength(2); k++) {
                if (arr[i, j, k] == num) {
                    return true;
                }
            }
        }
    }

    return false;
}

void print3DArr(int[,,] arr)
{
    Console.WriteLine("-----3D-Array-n(x,y,z)----");

    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            for (int k = 0; k < arr.GetLength(2); k++) {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }

    Console.WriteLine("--------------------------");
}

void main()
{
    int[,,] arr = gen3DArr(2, 2, 2);

    print3DArr(arr);
}

main();

 Console.WriteLine("--------------------------");
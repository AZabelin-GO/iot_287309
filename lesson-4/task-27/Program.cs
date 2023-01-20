// Task 27
//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("----- Task 27 -----");
Console.WriteLine("Enter ONE number");

int[] readNumber() {
    string num = Console.ReadLine().Trim();

    int[] res = new int[num.Length];

    int tmp;
    if (!int.TryParse(num, out tmp)) {
        Console.WriteLine("Error: cannot parse number");
        Environment.Exit(1);
    }


    for (int i = 0; i < num.Length; i++) {
        res[i] = num[i] - '0';
    }

    return res;
}

int calcArraySum(int[] arr) {
    int res = 0;

    for(int i = 0; i < arr.Length; i++) {
        res += arr[i];
    }

    return res;
}

void main() {
    int[] number = readNumber();

    Console.WriteLine(calcArraySum(number));
}

main();

Console.WriteLine("------------------");
// Task 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("----- Task 19 -----");
Console.WriteLine("Enter ONE number with 5 digits");

string num = Console.ReadLine().Trim();

int tmp;
if (!int.TryParse(num, out tmp)) {
    Console.WriteLine("Error: cannot parse number");
    Environment.Exit(1);
}

if ((Math.Abs(tmp) < 10000 ) && (Math.Abs(tmp) > 99999)) {
    Console.WriteLine("Error: number should consist of 5 digits, like 32145");
    Environment.Exit(1);
}

string reversedNum = string.Empty;
for (int i = num.Length - 1; i >= 0; i--) {
    reversedNum += num[i];
}

Console.WriteLine(num.TrimStart('-') == reversedNum.TrimEnd('-'));

Console.WriteLine("------------------");
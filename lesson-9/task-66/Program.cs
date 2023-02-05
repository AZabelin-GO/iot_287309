// Task 66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("----- Task 66 -----");

(int m, int n) genTwoNumbers(){
    Random rnd = new Random();

    int m = rnd.Next(0, 10);
    int n = rnd.Next(0, 10);

    if (m > n ) {
        return (n, m);
    }

    return (m, n);
}

int calcSumBetweenNumbers(int m, int n) {
    if (m == n) {
        return m;
    }

    return n + calcSumBetweenNumbers(m, n - 1);
}

void main() {
    var (m, n) = genTwoNumbers();
    Console.WriteLine($"The sum of numbers between {m} and {n} is {calcSumBetweenNumbers(m, n)}");
}

main();
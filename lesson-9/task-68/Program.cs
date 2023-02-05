// Task 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("----- Task 68 -----");

(int m, int n) genTwoNumbers(){
    Random rnd = new Random();

    int m = rnd.Next(0, 5);
    int n = rnd.Next(0, 5);

    return (m, n);
}

int ack(int m, int n) {
    if (m == 0) {
        return n + 1;
    } else if (n == 0) {
        return ack(m - 1, 1);
    }

    return ack(m - 1, ack(m, n - 1));
}

void main() {
    var (m, n) = genTwoNumbers();
    Console.WriteLine($"Ack({m}, {n}) = {ack(m, n)}");
}

main();
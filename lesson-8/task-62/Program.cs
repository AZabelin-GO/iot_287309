// Task 62
// Напишите программу, которая заполнит спирально массив 4 на 4.

namespace Task62;

internal class Task62
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- Task 62 -----");

        Game game = new Game(4, 4);

        game.Play();

        game.ShowBoard();
    }
}

public class Game
{
    Marker marker;

    public Game(int x, int y)
    {
        this.marker = new Marker(new int[x, y]);
    }

    public void ShowBoard()
    {
        marker.ShowMap();
    }

    public void Play()
    {
        while (this.marker.CanMove())
        {
            while (this.marker.CanMoveRight())
            {
                this.marker.MoveRight();
            }
            while (this.marker.CanMoveDown())
            {
                this.marker.MoveDown();
            }
            while (this.marker.CanMoveLeft())
            {
                this.marker.MoveLeft();
            }
            while (this.marker.CanMoveUp())
            {
                this.marker.MoveUp();
            }
        }
    }
}

public class Marker
{
    int row;
    int col;

    int step;

    int[,] map;

    public Marker(int[,] map)
    {
        this.map = map;
        this.row = 0;
        this.col = 0;
        this.step = 1;

        this.map[this.row, this.col] = this.step;
        this.step++;
    }

    public bool CanMoveLeft()
    {
        if (this.col > 0 && this.map[this.row, this.col - 1] == 0)
        {
            return true;
        }

        return false;
    }
    public bool CanMoveRight()
    {
        if (this.col < this.map.GetLength(1) - 1 && this.map[this.row, this.col + 1] == 0)
        {
            return true;
        }

        return false;
    }
    public bool CanMoveUp()
    {
        if (this.row > 0 && this.map[this.row - 1, this.col] == 0)
        {
            return true;
        }

        return false;
    }
    public bool CanMoveDown()
    {
        if (this.row < this.map.GetLength(0) - 1 && this.map[this.row + 1, this.col] == 0)
        {
            return true;
        }

        return false;
    }

    public bool CanMove()
    {
        return this.CanMoveLeft() || this.CanMoveRight() || this.CanMoveUp() || this.CanMoveDown();
    }

    public void MoveLeft()
    {
        this.col--;
        this.map[this.row, this.col] = this.step;
        this.step++;
    }

    public void MoveRight()
    {
        this.col++;
        this.map[this.row, this.col] = this.step;
        this.step++;
    }

    public void MoveUp()
    {
        this.row--;
        this.map[this.row, this.col] = this.step;
        this.step++;
    }

    public void MoveDown()
    {
        this.row++;
        this.map[this.row, this.col] = this.step;
        this.step++;
    }

    public void ShowMap()
    {
        Console.WriteLine("-----2D-Array-----");

        for (int i = 0; i < this.map.GetLength(0); i++)
        {
            for (int j = 0; j < this.map.GetLength(1); j++)
            {
                Console.Write($"{this.map[i, j].ToString("D2")} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine("------------------");
    }
}



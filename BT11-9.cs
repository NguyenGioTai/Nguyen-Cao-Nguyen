using System;

class BaiTap
{
    // Bài 1: Tạo mảng số nguyên và tính tổng
    public void Tinhtong()
    {
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }

        Console.WriteLine("Tổng các phần tử trong mảng là: " + sum);
    }

    // Bài 2: Đếm số lượng ký tự trong chuỗi (không tính khoảng trắng và dấu câu)
    public void Dem()
    {
        Console.Write("Nhập chuỗi: ");
        string input = Console.ReadLine();
        int count = 0;

        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                count++;
            }
        }

        Console.WriteLine("Số lượng ký tự trong chuỗi là: " + count);
    }

    // Bài 3: Tìm phần tử lớn nhất trong mảng
    public void TimMax()
    {
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array[0];

        for (int i = 1; i < n; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        Console.WriteLine("Phần tử lớn nhất trong mảng là: " + max);
    }

    // Bài 4: Đảo ngược chuỗi
    public void Dao()
    {
        Console.Write("Nhập chuỗi: ");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        Console.WriteLine("Chuỗi sau khi đảo ngược là: " + reversedString);
    }

    // Bài 5: Kiểm tra mảng đối xứng (Palindrome)
    public void Kiemtra()
    {
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        bool isPalindrome = true;

        for (int i = 0; i < n / 2; i++)
        {
            if (array[i] != array[n - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Mảng là đối xứng (Palindrome).");
        }
        else
        {
            Console.WriteLine("Mảng không phải là đối xứng (Palindrome).");
        }
    }

    // Bài 6: Đếm số lần xuất hiện của một ký tự trong chuỗi
    public void Demsoxh()
    {
        Console.Write("Nhập chuỗi: ");
        string input = Console.ReadLine();
        Console.Write("Nhập ký tự cần đếm: ");
        char character = char.Parse(Console.ReadLine());
        int count = 0;

        foreach (char c in input)
        {
            if (c == character)
            {
                count++;
            }
        }

        Console.WriteLine($"Số lần xuất hiện của ký tự '{character}' là: " + count);
    }

    static void Main(string[] args)
    {
        BaiTap program = new BaiTap();

        // Gọi các phương thức
        program.Tinhtong();
        program.Dem();
        program.TimMax();
        program.Dao();
        program.Kiemtra();
        program.Demsoxh();
    }
}

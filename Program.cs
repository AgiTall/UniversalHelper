using System.Text;

record Employee(string Name, string Position = "Не указана", decimal Salary = 0);
class Car
{
    public void ShowInfo(string brand) => Console.WriteLine(brand);
    public void ShowInfo(string brand, int year) => Console.WriteLine($"{brand}, {year}");
    public void ShowInfo(string brand, int year, decimal price) => Console.WriteLine($"{brand}, {year}, {price:C}");
}
class Student
{
    public string CalculateGrade(int x) => $"Оценка: {x}";
    public string CalculateGrade(int a, int b) => $"Средняя: {(a + b) / 2.0:F2}";
    public string CalculateGrade(int a, int b, int c) => $"Средняя: {(a + b + c) / 3.0:F2}";
}
class DiscountSystem
{
    public decimal CalculateDiscount(decimal p, int percent) => p * (1 - percent / 100m);
    public decimal CalculateDiscount(decimal p, decimal fixedDiscount) => p - fixedDiscount;
}
class Delivery
{
    public decimal CalculateDelivery(decimal distance) => distance * 10;
    public decimal CalculateDelivery(decimal distance, bool urgent) => distance * (urgent ? 20 : 10);
    public decimal CalculateDelivery(decimal distance, decimal weight) => distance * 10 + weight * 5;
}
class Book
{
    public void DisplayBook(string title) => Console.WriteLine(title);
    public void DisplayBook(string title, string author) => Console.WriteLine($"{title} — {author}");
    public void DisplayBook(string title, string author, int year) => Console.WriteLine($"{title} — {author}, {year}");
}
class Game
{
    public int AddScore(int score) => score + 100;
    public int AddScore(int score, int bonus) => score + bonus;
    public int AddScore(int score, double multiplier) => (int)(score * multiplier);
}
class Files
{
    public void SaveFile(string text, string path) => File.WriteAllText(path, text);
    public void SaveFile(string[] lines, string path) => File.WriteAllLines(path, lines);
    public void SaveFile(string text, string path, Encoding encoding) => File.WriteAllText(path, text, encoding);
}
class Geometry
{
    public double CalculateVolume(double side) => Math.Pow(side, 3);
    public double CalculateVolume(double a, double b, double c) => a * b * c;
    public double CalculateVolume(double r, double h) => Math.PI * r * r * h;
}
class Taxi
{
    public decimal CalculateFare(double km) => 100 + (decimal)km * 30;
    public decimal CalculateFare(double km, int wait) => 100 + (decimal)km * 30 + wait * 5;
    public decimal CalculateFare(double km, string cls) => 100 + (decimal)km * (cls == "business" ? 60 : 30);
}
class Library
{
    public string[] SearchBook(string q, string[] titles) => titles.Where(x => x.Contains(q, StringComparison.OrdinalIgnoreCase)).ToArray();
    public string[] SearchBook(string q, string[] titles, string[] authors) => titles.Zip(authors, (t, a) => (t, a)).Where(x => x.t.Contains(q, StringComparison.OrdinalIgnoreCase) || x.a.Contains(q, StringComparison.OrdinalIgnoreCase)).Select(x => $"{x.t} — {x.a}").ToArray();
}
class Arrays
{
    public int[] Sort(int[] a) { Array.Sort(a); return a;
} public double[] Sort(double[] a) { Array.Sort(a); return a;
} public string[] Sort(string[] a) { Array.Sort(a); return a;
    }
}
class Statistics
{
    public (double min, double max, double avg) Analyze(int[] a) => (a.Min(), a.Max(), a.Average());
    public (double min, double max, double avg) Analyze(double[] a) => (a.Min(), a.Max(), a.Average());
}
class Password
{
    public bool ValidatePassword(string p, int min) => p.Length >= min;
    public bool ValidatePassword(string p, int min, bool digits) => ValidatePassword(p, min) && (!digits || p.Any(char.IsDigit));
    public bool ValidatePassword(string p, int min, bool digits, bool special) => ValidatePassword(p, min, digits) && (!special || p.Any(ch => !char.IsLetterOrDigit(ch)));
}
class Currency
{
    public decimal ConvertCurrency(decimal sum) => sum * 0.92m;
    public decimal ConvertCurrency(decimal sum, decimal rate, decimal commission) => sum * rate * (1 - commission / 100);
}
class Dates
{
    public string FormatDate(DateTime d) => d.ToString("dd.MM.yyyy");
    public string FormatDate(string d) => DateTime.Parse(d).ToString("dd.MM.yyyy");
    public string FormatDate(DateTime d, bool time) => d.ToString(time ? "dd.MM.yyyy HH:mm" : "dd.MM.yyyy");
}
class Notifications
{
    public void SendNotification(string text) => Console.WriteLine(text);
    public void SendNotification(string title, string text) => Console.WriteLine($"{title}: {text}");
    public void SendNotification(string title, string text, string to) => Console.WriteLine($"[{to}] {title}: {text}");
}
class Employees
{
    public Employee CreateEmployee(string n) => new(n);
    public Employee CreateEmployee(string n, string p) => new(n, p);
    public Employee CreateEmployee(string n, string p, decimal s) => new(n, p, s);
}
class Stock
{
    public int UpdateStock(int old, int add) => old + add;
    public int UpdateStock(int old, int amount, bool decrease) => old + (decrease ? -amount : amount);
    public int UpdateStock(int old, int value, string mode) => mode == "set" ? value : old;
}
class MathLibrary
{
    public double Calculate(double a, double b, char op) => op switch { '+' => a + b, '-' => a - b, '*' => a * b, '/' => b == 0 ? throw new DivideByZeroException() : a / b, _ => throw new ArgumentException() };
    public int Calculate(int a, int b, char op) => (int)Calculate((double)a, b, op);
}
class Auth
{
    public bool Login(string login, string password) => login == "admin" && password == "1234";
    public bool Login(string email, string password, bool isEmail) => isEmail && email.Contains('@') && password.Length > 0;
    public bool Login(string login, string password, string code) => Login(login, password) && code == "0000";
}
class ImageTools
{
    public (int w, int h) ResizeImage(int w, int h, int nw, int nh) { if (w <= 0 || h <= 0 || nw <= 0 || nh <= 0) throw new ArgumentException(); return (nw, nh);
} public (int w, int h) ResizeImage(int w, int h, double scale) => ResizeImage(w, h, (int)(w * scale), (int)(h * scale));
    public (int w, int h) ResizeImage(int w, int h, int maxW, int maxH, bool keep) { if (!keep) return ResizeImage(w, h, maxW, maxH); var k = Math.Min((double)maxW / w, (double)maxH / h); return ResizeImage(w, h, (int)(w * k), (int)(h * k));
    }
}
class Transport
{
    public decimal CalculateFuelCost(double km, double consumption) => (decimal)(km * consumption / 100);
    public decimal CalculateFuelCost(double km, double consumption, decimal price) => (decimal)(km * consumption / 100) * price;
}
class Electronics
{
    public decimal CalculateFinalPrice(decimal p, int discount) => p * (1 - discount / 100m);
    public decimal CalculateFinalPrice(decimal p, int discount, int tax) => CalculateFinalPrice(p, discount) * (1 + tax / 100m);
    public decimal CalculateFinalPrice(decimal p, int discount, int tax, decimal delivery) => CalculateFinalPrice(p, discount, tax) + delivery;
}
class Evaluation
{
    public string EvaluateStudent(int exam) => Grade(exam);
    public string EvaluateStudent(int exam, int test) => Grade((exam + test) / 2.0);
    public string EvaluateStudent(int[] exams) => Grade(exams.Average()); string Grade(double x) => x >= 90 ? "5" : x >= 75 ? "4" : x >= 60 ? "3" : "2";
}
class Helper
{
    public double Calculate(double a, double b, char op) => new MathLibrary().Calculate(a, b, op);
    public string Format(double n) => n.ToString("F2");
    public string Format(string s) => s.Trim();
    public string Format(DateTime d) => d.ToString("dd.MM.yyyy");
    public int Find(int[] a, int x) => Array.IndexOf(a, x);
    public bool Find(string s, string part) => s.Contains(part);
    public void Display<T>(T x) => Console.WriteLine(x);
}

class Program
{
    static void Main()
    {
        var h = new Helper(); h.Display("Демонстрация Helper"); Console.WriteLine(h.Calculate(6, 2, '*')); Console.WriteLine(h.Format(3.14159)); Console.WriteLine(h.Format("  привет  ")); Console.WriteLine(h.Format(DateTime.Now)); Console.WriteLine(h.Find(new[] { 1, 2, 3 }, 2)); Console.WriteLine(h.Find("универсальный помощник", "помощник")); h.Display(new Employee("Иван", "Разработчик", 100000)); Console.WriteLine("Задание выполнено: реализованы все 25 пунктов и перегрузки методов.");
    }
}

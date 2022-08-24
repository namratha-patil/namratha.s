// See https://aka.ms/new-console-template for more information
class myclass
{
    enum grade { pass = 60, Distinotion = 85 };
    public  static string GetGrade(int mark)
    {
        if (mark >= (int)grade.Distinotion)
        {
            return  "Distinotion";
        }
        else if (mark >= (int)grade.pass)
        { return "PASS "; 
        }
        else
        {
            return "FAIL";
        }
    }
    public static void Main()
    {
        int empid;
        int mark;

        Console.WriteLine("What your empid?");
        empid = int.Parse(Console.ReadLine());
        Console.WriteLine($"thanks for giving your empid {empid}");

        Console.WriteLine("Enter your TSQL mark?");
        mark = Convert.ToInt32(Console.ReadLine());

        string grade = GetGrade(mark);
        Console.WriteLine($"you have scored {mark} and you are in {grade} grade");

        grade = GetGrade(45);
        Console.WriteLine($"you have scored 45 and you are in {grade} grade");
    }
}

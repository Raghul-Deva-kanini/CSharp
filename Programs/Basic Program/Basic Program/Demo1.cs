/*using Basic_Program;
using System.Net.Http.Headers;

class Demo1
{
    public static void Main(string[] args)
    {

        
        //Demo3 demo3 = new Demo3();
        /*Console.WriteLine("S==> 2 numbers M==> 3");
        String ch = Console.ReadLine();
        switch (ch)
        {
            case "s" or "S":
                demo3.Big2Num();
                break;
            case "m" or "M":
                demo3.Big3Num();
                break;
            default:
                Console.WriteLine("Enter S or M");
                break;
        }
        */
// demo3.do_loop();
// demo3.while_loop();
// Console.WriteLine("Enter the max value to find sum of the square of the number");
// int max = Convert.ToInt32(Console.ReadLine());
// int sum = demo3.for_loop(max);
// Console.WriteLine(sum);
//string str1= Console.ReadLine();
//demo3.for_each(str1);
//demo3.array_display();

/*Console.WriteLine("Enter Customer ID, account number, name, balance and status");
int custid = Convert.ToInt32(Console.ReadLine());
long accno = Convert.ToInt64(Console.ReadLine());
string accname = Console.ReadLine();
decimal balance = Convert.ToDecimal(Console.ReadLine());
BankTransactions bankTransactions = new BankTransactions(custid, accno, accname, balance);
bankTransactions.displayCustomerDetails();*/

/*int custid = 1;
long accno = 123;
string accname = "Rad";
Decimal balance = 1000;
BankTransactions bktr = new BankTransactions(custid, accno, accname, balance);
decimal bal = bktr.PerformTransactions();
Console.WriteLine($"ID : {bktr.Custid}, Accno : {bktr.Accno}, Name :{bktr.Accname}, Balance:{bal},Status:{bktr.Status}");  */


/*Console.WriteLine("Enter roll num, name and 3 marks");
int roll_no = Convert.ToInt32(Console.ReadLine());
string name = Console.ReadLine();
double mark1 = Convert.ToDouble(Console.ReadLine());
double mark2 = Convert.ToDouble(Console.ReadLine());
double mark3 = Convert.ToDouble(Console.ReadLine());

StudentCalculation studentCalculation = new StudentCalculation(roll_no, name, mark1, mark2, mark3, 0, 0);
studentCalculation.Calculate();
Console.WriteLine("Roll No : " + studentCalculation.Roll_no+"\n"+ "Name : " + studentCalculation.Name + "\n" +
    "Total : " + studentCalculation.Total + "\n" + "Average : " + studentCalculation.Avg
    );

Console.WriteLine("Enter college name, address, pincode");
string collegeName = Console.ReadLine();
string address= Console.ReadLine();
int pincode = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Teaching staff - empid, name, dept, fav subject, salaryTS");
int empid = Convert.ToInt32(Console.ReadLine());    
string name = Console.ReadLine();
string dept = Console.ReadLine();
string favsub = Console.ReadLine();
double salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Admin staff - empid, name, salary");
int aempid = Convert.ToInt32(Console.ReadLine());
string aname = Console.ReadLine();
double asalary = Convert.ToDouble(Console.ReadLine());

TeachingStaff teachingStaff = new TeachingStaff(empid, name, dept, favsub, salary, collegeName, address, pincode);
AdminStaff adminStaff = new AdminStaff(aempid, aname, asalary, collegeName, address, pincode);

double tsal = teachingStaff.calculate_salary();
double asal = adminStaff.calculate_salary();
Console.WriteLine("College name :" + teachingStaff.CollegeName);
Console.WriteLine("Teching staff name :" + teachingStaff.Name);
Console.WriteLine("Teaching staff salary : " + tsal);
Console.WriteLine("Admin staff name : " + adminStaff.Name);
Console.WriteLine("Admin staff salary :" + asal);
Console.Read();

// Console.WriteLine("Enter two numbers");
Addition addition = new Addition();
int n3 = 10; int n4 = 10;
Addition.add(n3, n4, out int n1, out int n2);
Console.WriteLine(n1 + " " + n2);


Interest interest = new Interest(10, 1234, "Rad", 20000, 0);
double intamt = interest.CalculateInterest();
Console.WriteLine(interest.Acc + interest.Acname + intamt);


Sample sample = new Sample();
int addres = sample.intadd(5, 5);
string addstr = sample.stradd("Ra", "hul");
Console.WriteLine(addres);
Console.WriteLine(addstr);



Animals dog = new Animals("dog", 2, 1, 4, 1, "hi", "hi", 0);
Animals cow = new Animals("cow", 2, 1, 4, 1);
Animals cat = new Animals("cat", 2, 1, 4, 1);
cat.MakeSound(cat.Name);
cow.Type(cow.Name);
dog.Type(dog.Name);
dog.MakeSound(dog.Name);


BankAccount bankAccount = new BankAccount(1234, 987654321, "AAA", 10000);

Console.WriteLine("1. Customer ID, 2. Account Number");
int ch = Convert.ToInt32(Console.ReadLine());
switch(ch)
{
    case 1:
        bankAccount.checkaccstatus();
        Console.WriteLine(bankAccount.Accno+bankAccount.Name+ bankAccount.Balance + bankAccount.Status);
        break;

    case 2:
        //bankAccount.checkaccstatus(987654321, out int custid, out string name2, out double balance2, out string status2);
        bankAccount.checkaccstatus(987654321);
        Console.WriteLine(bankAccount.Custid + bankAccount.Name + bankAccount.Balance + bankAccount.Status);
        break;

    default:
        Console.WriteLine("Please enter 1 or 2");
        break;
}


BankAccount bk = new BankAccount();
bk = bankAccount;
Console.WriteLine(bk.Accno+ bk.Name);



StudentCalculation studentCalculation = new StudentCalculation(1, "A", 100, 98, 98);
studentCalculation.show();


EnumDemo enumDemo = new EnumDemo();
enumDemo.display();



ExceptionHandling exceptionHandling = new ExceptionHandling(10, 10, 0);

//Console.WriteLine(exceptionHandling.add());
//Console.WriteLine(exceptionHandling.mul());
//Console.WriteLine(exceptionHandling.div());

try
{
    exceptionHandling.CheckVal(-1);
}
catch(ArgumentException excep)
{
    Console.WriteLine(excep.Message);
}
catch(ArithmeticException excep)
{
    Console.WriteLine(excep.Message);
}



FileOperation fileOperation = new FileOperation();
fileOperation.CreateFile();
//fileOperation.DeleteFile();
//fileOperation.CopyMoveFile();
//fileOperation.WriteData();
//fileOperation.ReadData();
fileOperation.FileProperties();



GenericCollectionDemo gcd = new GenericCollectionDemo();
//gcd.ListElements();

//gcd.StackElements();

//gcd.QueueElements();

//gcd.HashElements();

//gcd.SortedListElements();

NonGenericCollectionDemo ngcd = new NonGenericCollectionDemo();
ngcd.ArrayListElements();

ngcd.StackElements();

ngcd.QueueElements();

ngcd.HashElements();

ngcd.SortedListElements();


JaggedArray jaggedArray = new JaggedArray();
//jaggedArray.display();
jaggedArray.display_multiDimension();


LambdaExpression le = new LambdaExpression();
le.evennumbers();


BankDetails bd = new BankDetails(12345, "ABC", 10000, 0);
bd.bank_regex();



int[] arr = new int[5];
Console.WriteLine("Array length : "+ arr.Length);
Console.WriteLine("Enter the elaments");
for(int i=0;i<arr.Length;i++)
{
    arr[i]= Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Array elements are");
for (int i = 0; i < arr.Length; i++)
{
    for(int j=i+1;j<arr.Length;j++)
    {
        if (arr[i] > arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}



//StaticDemo sd = new StaticDemo();

StaticDemo.calc();
StaticDemo.disp();
Console.WriteLine(StaticDemo.Amt);

PartialDemo pd = new PartialDemo(10, 10, 0);
Console.WriteLine(pd.calc());


FileOperations fileOperations = new FileOperations();
if (fileOperations.createfile()==false)
{
    Console.WriteLine("The file exists/created and operable");
}
else
{
    Console.WriteLine("The file is not operable");
}
fileOperations.writingToFile();
fileOperations.readFromFile();


stringDuplication stringDuplication = new stringDuplication();
stringDuplication.findDuplicate();


Consecutives consecutives= new Consecutives();
Console.WriteLine("Enter the string : ");
string input = Console.ReadLine();
consecutives.display_consecutives(input);



Console.WriteLine("Enter the age");
int age = Convert.ToInt32(Console.ReadLine());
Person person = new Person(age);
Console.WriteLine("Reading age with property.....");
Console.WriteLine($"Age of person is {person.Age}");
try
{
    person.validate_age(age);
}
catch (InvalidAgeException e)
{
    Console.WriteLine(e);
}
finally
{
    Console.WriteLine("Age is validated");
}
CurrencyConverter converter = new CurrencyConverter();
converter.Conversations();


EbCalculator calculator = new EbCalculator();
calculator.EnterReading();
Console.WriteLine($"EB charge {calculator.Unit} units is Rs. " + calculator.CalculateBill());

Temperature temperature = new Temperature();
temperature.Conversion();


string file_path = "D:\\C# training\\allyears.txt";
string leap_year_file_path = "D:\\C# training\\leapyears.txt";
string non_leapyear_file_path = "D:\\C# training\\nonleapyears.txt";


FileOperations2 fo = new FileOperations2(file_path, leap_year_file_path, non_leapyear_file_path);
fo.read_file();
fo.write_to_leapyear();
fo.write_to_nonleapyear();

string s1 = Console.ReadLine();
string s2 = Console.ReadLine();

DataTransfer dt = new DataTransfer();
dt.process(s1, s2);
}
}

*/

using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string[] line1 = Console.ReadLine().Split();
        int n = int.Parse(line1[0]); // number of armies
        int q = int.Parse(line1[1]); // number of events

        // initialize the armies with empty soldier lists
        List<int>[] armies = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            armies[i] = new List<int>();
        }

        // keep track of the soldiers' combat abilities in each army
        int[] maxCombat = new int[n];
        for (int i = 0; i < n; i++)
        {
            maxCombat[i] = int.MinValue;
        }

        // handle each event
        for (int i = 0; i < q; i++)
        {
            string[] line = Console.ReadLine().Split();
            int type = int.Parse(line[0]);

            if (type == 1)
            { // print maximum combat ability in army
                int army = int.Parse(line[1]) - 1; // 0-based indexing
                Console.WriteLine(maxCombat[army]);
            }
            else if (type == 2)
            { // remove soldier with max combat ability
                int army = int.Parse(line[1]) - 1; // 0-based indexing
                int maxCombatIndex = armies[army].Count - 1;
                for (int j = armies[army].Count - 2; j >= 0; j--)
                {
                    if (armies[army][j] > armies[army][maxCombatIndex])
                    {
                        maxCombatIndex = j;
                    }
                }
                armies[army].RemoveAt(maxCombatIndex);
                if (armies[army].Count > 0)
                {
                    maxCombat[army] = armies[army][armies[army].Count - 1];
                }
                else
                {
                    maxCombat[army] = int.MinValue;
                }
            }
            else if (type == 3)
            { // add soldier with combat ability
                int army = int.Parse(line[1]) - 1; // 0-based indexing
                int combat = int.Parse(line[2]);
                armies[army].Add(combat);
                if (combat > maxCombat[army])
                {
                    maxCombat[army] = combat;
                }
            }
            else
            { // merge armies
                int army1 = int.Parse(line[1]) - 1; // 0-based indexing
                int army2 = int.Parse(line[2]) - 1; // 0-based indexing
                armies[army1].AddRange(armies[army2]);
                armies[army2] = null; // mark army2 as removed
                maxCombat[army1] = Math.Max(maxCombat[army1], maxCombat[army2]);
                maxCombat[army2] = int.MinValue;
            }
        }
    }
}






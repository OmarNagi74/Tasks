namespace task1;
using b;

class Program
{
    static void Main(string[] args)
    {
        #region q1
object o = new Book();
Console.WriteLine(o);
#endregion
#region q2
Book b = new Book();
    Book b2 = new Book();
    Console.WriteLine(b.Equals(b));
    Console.WriteLine(b.GetHashCode());
    Console.WriteLine(b.GetType());
    Console.WriteLine(b.ToString());
Console.WriteLine(b.Equals(b2));
#endregion
#region q3
/*int pages = "464";
compiler error
*/
int pages = 464;

#endregion
#region q4

try
{
    int x = 0;
    Console.WriteLine(10 / x);
}
catch (Exception e)
{
    Console.WriteLine("cannot divide by zero");
}
finally
{
    Console.WriteLine("finally block");
}

#endregion
#region q5

int w = 300;
double y = w;


#endregion
#region q6

double t = 29.99;
int z = (int)t;

#endregion
#region q7
string s = "123";
int i = Convert.ToInt32(s);
#endregion

#region q8
string s1 = "2023";
int i1 = int.Parse(s1);
bool b1 = int.TryParse(s1, out i1);
if(!b1)
    Console.WriteLine("not a number");
else
{
    Console.WriteLine(i1);
}


#endregion
#region q9

int q = 124;
string s2 = q.ToString();
Console.WriteLine(s2.GetType());
#endregion

#region q10

int p = 123;
object o1 = p;
object o2 = 123;
int q1 = (int)o2;
Console.WriteLine(o1.GetType());
Console.WriteLine(q1.GetType());
#endregion

    }
}
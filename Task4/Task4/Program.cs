namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        #region q1
        book b = new book();
        //b.password = "";//cannot access a member with the name "password" because it is in a private scope

        #endregion

        #region q2

        b.copiesinstock = 10;
        Console.WriteLine(b.copiesinstock);

        #endregion

        #region Q3

        b.title = "C#";
        Console.WriteLine(b.title);

        #endregion

        #region Q4
b.genre = genre.science;
Console.WriteLine(b.genre);
        

        #endregion

        #region q5

        Console.WriteLine((int)genre.fiction);
        Console.WriteLine((int)genre.nonfiction);
        Console.WriteLine((int)genre.science);

        #endregion

        #region Q6

        Console.WriteLine((genre)1);

        #endregion

        #region Q7

        Console.WriteLine(genre.fiction.ToString());

        #endregion

        #region Q8

        string s = "science";
        Console.WriteLine((genre)Enum.Parse(typeof(genre), s));

        #endregion

        #region Q9
        string s1 = "mystery";

        bool r=Enum.TryParse<genre>(s1, true, out genre g);
        Console.WriteLine(r?g.ToString():"unknown genre");
        #endregion
    }
}

class book
{
    private string password;
    public string title;
   internal int copiesinstock;
   public genre genre;
}

enum genre
{fiction, nonfiction,science
}


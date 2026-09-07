namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        #region q1
        double[] price = [25.5, 40.0, 33.75];
Console.WriteLine(price[1]);
        #endregion

        #region q2
        int[,] shelfCopies =
        {
            { 3, 5 },
            { 1, 4 }
        };

        Console.WriteLine(shelfCopies[1, 0]);
        

        #endregion
        #region q3
        PrintWelcomeMessage();
        #endregion

        #region q4
PrintBookTitle("clean code");
        

        #endregion

        #region q5

        int pages = 400;
        AddBonusPages(pages);
        Console.WriteLine(pages);

        #endregion

        #region q6

        double[] prices = { 25.5, 40.0 };

        ApplyDiscount(prices);

        Console.WriteLine(prices[0]);

        #endregion

        #region q7
        int pages2 = 400;
        AddBonusPagesByRef(ref pages2);
        Console.WriteLine(pages2);

        

        #endregion

        #region q8
        double[] pricess = { 25.5, 40.0 };

        ReplaceArray(ref pricess);

        Console.WriteLine(pricess.Length);

        

        #endregion

        #region q9

        

        bool found = TryGetPrice("Clean Code", out double pricea);

        if (found)
        {
            Console.WriteLine(price);
        }

        #endregion

        #region q10
        PrintBookInfo("Clean Architecture", 400);
        

        #endregion

        #region q11

        PrintBookInfoo(pages: 500, title: "Clean Code");

        #endregion

        #region q12


        PrintAllTitles(
            "Clean Code",
            "The Pragmatic Programmer",
            "Clean Architecture"
        );        

        #endregion
    }
    
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
    }
    static void PrintBookTitle(string title)
    {
        Console.WriteLine("Book title: " + title);
    }
    static void AddBonusPages(int pages)
    {
        pages += 50;
    }
    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5;
    }
    static void AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
    }
    static void ReplaceArray(ref double[] prices)
    {
        prices = new double[] { 10.0, 12.5, 15.0 };
    }

    static bool TryGetPrice(string title, out double price)
    {
        if (title == "Clean Code")
        {
            price = 25.5;
            return true;
        }

        price = 0;
        return false;
    }
    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Pages: " + pages);
    }
    static void PrintBookInfoo(string title, int pages = 300)
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Pages: " + pages);
    }
    static void PrintAllTitles(params string[] titles)
    {
        foreach (string title in titles)
        {
            Console.WriteLine(title);
        }
    }

}
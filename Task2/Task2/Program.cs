namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        #region  q1

        int pages = 456;
        bool isAvailable = true;
        if(pages > 300 && isAvailable)
            Console.WriteLine("Book is available");
        else
        {
            Console.WriteLine("Book is not available");
        }


        #endregion

        #region q2

        string title = "refactoring";
        switch (title)
        {
            case "refactoring":
                case " Never heard of it":
                Console.WriteLine("else");
                break;
            case "Clean Code":
                case "nice pick":
                Console.WriteLine("great choose");
                break;
            
        }
        #endregion

        #region q3
        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
        #endregion

        #region q4 string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        for(int i=0; i<books.Length; i++)
            Console.WriteLine(books[i]+"," + (i+1) );
        #endregion

        #region q5

        int w= 0;
        while (w<books.Length)
        {Console.WriteLine(books[w++]+" "+(w));
            
        }


        #endregion

        #region  q6

        int x = 0;
        do
        {
Console.WriteLin
    }
    
}
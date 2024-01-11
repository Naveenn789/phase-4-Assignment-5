// See https://aka.ms/new-console-template for more information

using ConAppMovies;

string? c="";
List<Movies> movies = new List<Movies>()
{
    new Movies(){Id=1,Tittle="Bhahubali",Director="Rajamouli ",budget="50$M"},
    new Movies(){Id=2,Tittle="Pushpa 1",Director="Sukumar  ",budget="15$M"},
    new Movies(){Id=3,Tittle="3 Idiots",Director="Hirani R",budget="9$M"},
    new Movies(){Id=4,Tittle="Terminator",Director="Camaron J",budget="200$M"},
    new Movies(){Id=5,Tittle="Salaar 1",Director="Prashanth",budget="25$M"},
};


do
{
    Console.WriteLine("Choose opperation you want to do \n1.Display all data \n2.Retrive data by Tittle");
    int o = int.Parse(Console.ReadLine());
    switch (o)
    {
        case 1:
            Dispaly(movies);
            break;
        case 2:
            RetriveByTittle(movies);
            break;
        default:
            Console.WriteLine("You choose invalid operation");
            break;  
    }
    Console.WriteLine("Do you want to perform oerations again ? y/n");
    c = Console.ReadLine();
} while (c=="y");

static void Dispaly(List<Movies> movies)
{
    Console.WriteLine("Id\t Tittle \t Director \t Budget");
    foreach (var m in movies)
    {
        Console.Write(m.Id+"\t");
        Console.Write(m.Tittle + "\t");
        Console.Write(m.Director + "\t");
        Console.Write(m.budget + "\t");
        Console.WriteLine("\n");
    }
}

static void RetriveByTittle(List<Movies> movies)
{
    Console.WriteLine("Enter movie name to retrive the data");
    string? i = Console.ReadLine();
    Console.WriteLine("Id\t Tittle \t Director \t Budget");
    foreach (var m in movies)
    {
        if (m.Tittle==i)
        {
            Console.Write(m.Id + "\t");
            Console.Write(m.Tittle + "\t");
            Console.Write(m.Director + "\t");
            Console.Write(m.budget + "\t");
            Console.WriteLine("\n");
        }
    }
}
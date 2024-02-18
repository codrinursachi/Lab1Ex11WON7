partial class Program
{
    static int ReadNumber()
    {
        Console.WriteLine("Introduceti un numar pentru a fi clasificat");
        var numarRaw=Console.ReadLine();
        if(int.TryParse(numarRaw,out int numar))
            return numar;
        Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
        return ReadNumber();
    }
    static string ClassifyNumber(int numar)
    {
        switch (numar)
        {
            case 1:
                return "unu";
            case 2:
                return "doi";
            case 3:
                return "trei";
            case 5:
                return "cinci";
            case 8:
                return "opt";
            default:
                return "neidentificat";
        }
    }
    static void ShowClassification(string clasificare)
    {
        Console.WriteLine(clasificare);
    }
}
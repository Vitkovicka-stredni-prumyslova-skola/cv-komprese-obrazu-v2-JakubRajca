namespace Komprese
{
    public class KompreseObrazu{

        public static void Main (String [] args){
        
        
        //Cesta k testovacímu souboru
        String testFilePath = @"C:\Users\JakubRajča\github-classroom\Vitkovicka-stredni-prumyslova-skola\cv-komprese-obrazu-v2-JakubRajca\KompreseObrazu\CSV\obr1-10.csv";
        
        //vytvoření instance třídy Obrazek
        Obrazek inputCSV = new Obrazek(testFilePath);

        
        
       /* //Test metody, která spočítá počet řádků vstupního obrázku
        Console.WriteLine("Počet vertikálních řádků {0}",inputCSV.CountLines(testFilePath));
        
        //Test metody, která spočítá počet symbolů vstupního obrázku v prvním řádku
        Console.WriteLine("Počet horizontální řádků {0}",inputCSV.CountSymbolInLine(testFilePath)); 

        inputCSV.vypisImg(); */
        List<int> unikatniBarvy = inputCSV.PaletaBarevObrazku();
        foreach(int element in unikatniBarvy)
          Console.Write($"{element}, ");
        Console.WriteLine("\n-----------------------------------------------------------------");
        inputCSV.spocitatPix();
      }
    }
}
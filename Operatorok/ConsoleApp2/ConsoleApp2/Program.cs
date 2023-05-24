using ConsoleApp2;
using System.Linq;

internal class Program { 
    static List<Kifejezesek> kifejezesek = new List<Kifejezesek>();
            static void Main(string[] args) { 
         foreach (var sor in File.ReadAllLines("DataSource\\kifejezesek.csv"))
            {
                kifejezesek.Add(new Kifejezesek(sor));
            }
         //6.feladat
           public string Ertek()
        {
            var ertek = string.Empty;
            try
            {
                switch (this.kifejezesek)
                {
                    case "mod":
                        ertek = $"{this.elsoOperandus % this.masodikOperandus}";
                        break;
                    case "div":
                        ertek = $"{this.elsoOperandus / this.masodikOperandus}";
                        break;
                    case "+":
                        ertek = $"{this.elsoOperandus + this.masodikOperandus}";
                        break;
                    case "-":
                        ertek = $"{this.elsoOperandus - this.masodikOperandus}";
                        break;
                    case "*":
                        ertek = $"{this.elsoOperandus * this.masodikOperandus}";
                        break;
                    case "/":
                        ertek = $"{(double)this.elsoOperandus / this.masodikOperandus}";
                        break;
                    default:
                        ertek = "Hibás operátor!";
                        break;
                }
            }
            catch (Exception)
            {
                ertek = "Egyéb hiba!";
            }

            return ertek;
        }
        public override string ToString()
        {
            return $"{this.elsoOperandus} {this.kifejezesek} {this.masodikOperandus} = {this.Ertek()}";
        }
    }
         //2.feladta
         Console.WriteLine($"2.feladat: Kifejezések száma: {kifejezesek.Count}");
         //3.feladat
         Console.WriteLine($"3.feladat: Kifejezések maradékos osztással: {kifejezesek.Where(x=>x.oper == "mod").Count()}");
        //4.feladat
        Console.WriteLine($"4.feladat: {kifejezesek.Where(x=>x.elsoOperandus%10 == 0 && x.masodikOperandus%10 == 0)}");
        //5.feladat
        Console.WriteLine($"5.feladat: Statisztika \n mod -> {kifejezesek.Where(x=>x.oper == "mod").Count()} \n / -> { kifejezesek.Where(x=>x.oper == "/").Count()} \n div ->{kifejezesek.Where(x=>x.oper == "div").Count()} \n - -> {kifejezesek.Where(x=>x.oper== "-").Count()} \n * -> {kifejezesek.Where(x=>x.oper == "*").Count()} \n + -> {kifejezesek.Where(x=>x.oper=="+").Count()}");
        //7.feladat
       do 
            {
                Console.Write($"7. feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
                string input = Console.ReadLine();

                if (input == "vége")
                {
                    break;
                }

                Console.WriteLine($"{input} = {new Operandus(input).Ertek()}");
            }
            while (true);
        //8.feladat
        StreamWriter streamWriter = new StreamWriter("eredmenyek.csv");
            foreach (var item in operandusok)
            {
                streamWriter.WriteLine(item.ToString());
            }
        streamWriter.Flush();
        streamWriter.Close();
    }
 }
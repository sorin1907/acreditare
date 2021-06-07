using System;

namespace Fermatest1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("");
            // Console.ReadLine();
            MeniuFerma();




        }

private  static void MeniuFerma()
        {

            Console.WriteLine("Tastati una din cifre pentru a alege una din urmatoarele optiuni\nMeniu ferma : \n1. Adauga animale noi\n2. Configurare nevoi hrana\n3. Redu numar animale\n4. Adauga hrana animale\n5. Afiseaza situatie ferma\n6. Iesire");
            string optiunilemele;
            optiunilemele = Console.ReadLine();
            switch (optiunilemele)
            {
                case "1":
                    Adauga();
                    break;
                case "2":
                    Configurare();
                    break;
                case "3":
                    Reda();
                    break;
                case "4":
                    Adaugah();
                    break;
                case "5":
                    Afiseaza();
                    break;
                case "6":
                    Iesire();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Optiunea nu se afla in meniu tastati din nou");
                    MeniuFerma();
                    break;

            }



        }

       

        static void Adauga()
        {
            Console.Clear();
            Console.WriteLine("Adauga animale noi");
            Console.WriteLine("Doriti sa adaugati");
            Console.WriteLine("1.Patrupede");
            Console.WriteLine("2.Pasari");
            Console.WriteLine("3.Revino la meniul anterior");
            string noioptiuni;
            noioptiuni = Console.ReadLine();

            switch (noioptiuni)
            {

                case "1":
                    Patrupede();
                    break;
                case "2":
                    Pasari();
                    break;
                case "3":
                    Console.Clear();
                    MeniuFerma();
                    break;
                default:
                    
                    Console.Clear();
                    Console.WriteLine("Optiunea nu se afla in meniu tastati din nou");
                    Adauga();
                    break;

            }

        }

        static void Configurare()
        {


            Console.Clear();
            Console.WriteLine("Configurare nevoi hrana");
            Console.WriteLine("Introduceti categoria pe care vreti sa o comfirmati sau enter pentru revevenire la meniu");
            string porci = "Porci";
            string Oi = "oi";
            string Bovine = "bovine";
            string Cai = "cai";
            
            int fan = 0;
            int porumb = 1;
           
            string fan1 = Convert.ToString(fan);
            string porumb1 = Convert.ToString(porumb);
            PrintRow("Animale", "Porumb(kg/zi)", "Fan(kg/zi");
            PrintRow(porci, fan1, porumb1);
            PrintRow(Oi, "3", "2");
            PrintRow(Bovine, "3", "5");
            PrintRow(Cai, "2", "2");
        
            
            string Patrupedeeee;
            Patrupedeeee = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n Apasa tasta enter sa revi la meniul anterior");
            
            
            switch (Patrupedeeee)
            {
                case "porci":
                    Console.Clear();
                    Console.WriteLine("Setati mancarea pentru porci");
                    Console.WriteLine("Tastati cantitatea de fan");
                    int f = int.Parse(Console.ReadLine());
                    fan = f;
                    Console.WriteLine("Noua cantitate de fan este =");
                    Console.WriteLine(fan);
                    Console.WriteLine("Tastati cantitatea de porumb");
                    int p = int.Parse(Console.ReadLine());
                    porumb = p;
                    Console.WriteLine("Noua cantitate de fan este =");
                    Console.WriteLine(porumb);
                    ///rintRow(porci, fan1, porumb1);

                    Configurare();
                    


                    break;

            }
            Console.Clear();
            MeniuFerma();
           


        }
        static int tableWidth = 73;
    

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        static void Reda()
        {
            Console.Clear();
            Console.WriteLine("Redu numar animale");
            Console.ReadLine();

        }

        static void Adaugah()
        {
            Console.Clear();
            Console.WriteLine("Adauga hrana animale");
            Console.ReadLine();

        }

        static void Afiseaza()
        {
            Console.Clear();
            Console.WriteLine("Afiseaza situatie ferma");
            Console.ReadLine();

        }
        static void Iesire()
        {   
            Console.Clear();
            Console.WriteLine("Iesire");
            Console.WriteLine("Daca vreti sa iesiti apasati tasta enter");
            Console.ReadLine();
            System.Environment.Exit(1);
        }

    public  static void Patrupede()
        {
            string porci = "";
            string Oi = "";
            string Bovine = "";
            string Cai = "";
            int fan = 0;
            int porumb;
            Console.Clear();
            Console.WriteLine("Patrupede:\n 1.Porci\n 2.Oi\n 3.Bovine\n 4.Cai");
            string Patrupedeeee;
            Patrupedeeee = Console.ReadLine();
            switch (Patrupedeeee)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Setati mancarea pentru porci");
                    Console.WriteLine("Tastati cantitatea de fan");
                    int f = int.Parse(Console.ReadLine());
                    fan = f;
                    Console.WriteLine("Noua cantitate de fan este =");
                    Console.WriteLine(fan);
                    Console.WriteLine("Tastati cantitatea de porumb");
                    int p= int.Parse(Console.ReadLine());
                    porumb = p;
                    Console.WriteLine("Noua cantitate de fan este =");
                    Console.WriteLine(porumb);


                    break;

            }
          

        }

        static void Pasari()
        {
            Console.Clear();
            Console.WriteLine("Pasari: \n Gaini \n Gaste \n Rate \n Curci ");
            Console.ReadLine();
        }

        
    }
}

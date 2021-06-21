using System;


class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) {
            string[] line = Console.ReadLine().Split(" ");
            double X, Y;
            bool canConvertX = double.TryParse(line[0], out X);
            bool canConvertY = double.TryParse(line[1], out Y);
            if (Y == 0 || canConvertX == false || canConvertY == false)
                Console.WriteLine("divisao impossivel");
            else {
                double divisao = (double) (X / Y);
                if (divisao < 0 && divisao.ToString("N1") == "0.0")
                  Console.WriteLine("-0.0");
                else
                  Console.WriteLine(divisao.ToString("N1"));
            }
        }
    }
}
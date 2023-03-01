using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Password: ");
        int pass = int.Parse(Console.ReadLine());
        string password = pass.ToString();
        int pass1 = (pass / 100000) % 10;
        int pass2 = (pass / 10000) % 10;
        int pass3 = (pass / 1000) % 10;
        int pass4 = (pass / 100) % 10;
        int pass5 = (pass / 10) % 10;
        int pass6 = (pass / 1) % 10;
        if(password.Length == 6){
        Console.Write("Agency (e.g. FBI, CIA, NSA): ");
        string agen = Console.ReadLine();

        switch (agen) {
            case "CIA":
                if (pass6 % 3 ==0 && pass5 != 1 && pass5 != 3 && pass5 != 5 && pass3 >=6 && pass3 != 8){
                    Console.WriteLine("True");
                }
                else{
                    Console.WriteLine("False");
                }
                break;

            case "FBI":
                if (pass4 % 2 ==0 && pass4 != 6 && pass2 % 2 ==1 && pass1 >=4 && pass1<=7){
                    Console.WriteLine("True");
                }
                else{
                    Console.WriteLine("False");
                }
                break;

            case "NSA":
                if (30 % pass6 == 0  && pass4 % 3 ==0 && pass4 %2 ==1 && (pass1 ==7 || pass2 ==7 || pass3 ==7 || pass5 ==7)){
                    Console.WriteLine("True");
                    }
                else{
                    Console.WriteLine("False");
                }
                break;

            default:
                Console.WriteLine("False");
                break;
        }
        }
        else{
            Console.WriteLine("False");
        }
    }
}
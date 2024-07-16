using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt1_BT_TH
{
    internal class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("================Chuong trinh doan so==================");
                Random random = new Random();
            int targetNumber = random.Next(100, 999);
            string targetString = targetNumber.ToString();
            int attempt = 1, MAXGUESS = 7;
            string quess, feedback = "";

            while (feedback != "+++" && attempt <= MAXGUESS)
            {
                System.Console.Write("Lan don thu {0}: ", attempt);
                while(true)
                {
                    quess = System.Console.ReadLine();
                    if (quess.Length != 3)
                    {
                        System.Console.Write("Vui long nhap so co 3 chu so: ");
                    }
                    else
                    {
                        break;
                    }
                }
                feedback = GetFeedback(targetString, quess);
                System.Console.WriteLine("Phan hoi tu may tinh: {0}", feedback);
                attempt++;
            }
            Console.WriteLine("Nguoi chui da doan {0} Lan. Tro choi ket thuc", attempt - 1);
            if (attempt > MAXGUESS)
            {
                System.Console.WriteLine("Nguoi choi thua cuoc. So can doan la: {0}", targetNumber);
            }
            else
            {
                System.Console.WriteLine("Nguoi chơi thang cuoc!", attempt);
            }

        } 
        static string GetFeedback(string target, string quess)
        { 
            string feedback = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == quess[i])
                    feedback += "+";
                else if (target.Contains(quess[i].ToString()))
                    feedback += "?";
            }
            return feedback;
        }
    }
    
}

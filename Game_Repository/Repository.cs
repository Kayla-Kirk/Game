using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Repository
{
    public class Repository
    {
        static void Main(string[] args)
        {
        }

        public void User()
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hi " + userName + "!\n" + "Welcome to the Fortune Game!\n" +"Press any key to continue!");
            Console.ReadLine();
            Console.Clear();
        }

        public void Fortune1()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Watch out for a good time disguised as a bad reputation.", "A strong defense is better then no fence", "Help! I'm being held prisoner in CyberSpace!" };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);

        }

        public void Fortune2()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Believe in yourself, your hard work will pay off soon!", "Some say with age comes wisdom. I say with age comes forgetfulness", "Opps. Lost your fortune. Try again!" };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);

        }

        public void Fortune3()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Help! I'm being held prisoner in CyberSpace!", "I forsee many codes breaking in your furure.", "Practice makes perfect!" };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);

        }

        public void Fortune4()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Some say with age comes wisdom. I say with age comes forgetfulness", "Might be time to put your stock in something new, like a pot.", "Good job. You have one free token to nap!" };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);

        }

        public void Fortune5()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Does anyone else smell Chinese food", "Fortune not found ---- ERROR: 404", "Opps. Lost your fortune. Try again!" };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);

        }

        public void Fortune6()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "I forsee many codes breaking in your furure.", "A strong defense is better then no fence", "Roses are red, Violet are blue. This Gold Badge you'll get through" };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);

        }

        public void Fortune7()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Fortune not found ---- ERROR: 404", "Watch out for a good time disguised as a bad reputation.", "Is something burning? Nope, that's just me!" };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);

        }

        public void Fortune8()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Roses are red, Violet are blue. This Gold Badge you'll get through", "You are a certified kitty cat cuddler", "Believe in yourself, your hard work will pay off soon!" };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);

        }
    }
}

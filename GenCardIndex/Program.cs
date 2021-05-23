using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CardList
{
    public class CardDeck
    {
        string temp;
       
        List<string> cardlist;
        public CardDeck()
        {
            temp = "";
            cardlist = new List<string>();
            cardlist.Add("2S");
            cardlist.Add("3S");
            cardlist.Add("4S");
            cardlist.Add("5S");
            cardlist.Add("6S");
            cardlist.Add("7S");
            cardlist.Add("8S");
            cardlist.Add("9S");
            cardlist.Add("10S");
            cardlist.Add("JS");
            cardlist.Add("QS");
            cardlist.Add("KS");
            cardlist.Add("AS");
            cardlist.Add("2H");
            cardlist.Add("3H");
            cardlist.Add("4H");
            cardlist.Add("5H");
            cardlist.Add("6H");
            cardlist.Add("7H");
            cardlist.Add("8H");
            cardlist.Add("9H");
            cardlist.Add("10H");
            cardlist.Add("JH");
            cardlist.Add("QH");
            cardlist.Add("KH");
            cardlist.Add("AH");
            cardlist.Add("2C");
            cardlist.Add("3C");
            cardlist.Add("4C");
            cardlist.Add("5C");
            cardlist.Add("6C");
            cardlist.Add("7C");
            cardlist.Add("8C");
            cardlist.Add("9C");
            cardlist.Add("10C");
            cardlist.Add("JC");
            cardlist.Add("QC");
            cardlist.Add("KC");
            cardlist.Add("AC");
            cardlist.Add("2D");
            cardlist.Add("3D");
            cardlist.Add("4D");
            cardlist.Add("5D");
            cardlist.Add("6D");
            cardlist.Add("7D");
            cardlist.Add("8D");
            cardlist.Add("9D");
            cardlist.Add("10D");
            cardlist.Add("JD");
            cardlist.Add("QD");
            cardlist.Add("KD");
            cardlist.Add("AD");
            cardlist.Add("JOKER");
        }

        public static string getCardindex(string tempCardvalue,CardDeck tempCardDeck) //tempCardValue is my input and tempCardDeck is my new card deck
        {
            string cardvalues = tempCardvalue;
            CardDeck card = tempCardDeck;

            string[] cardSet = cardvalues.Split(' ');
                foreach (string tempcard in cardSet)
                {
                    card.temp += Convert.ToString(card.cardlist.IndexOf(tempcard)) + " ";
                    card.cardlist.Remove(tempcard);
                }
            return card.temp;

        }


       // static void Main(string[] args)
        //{
        
          //  Console.WriteLine(@"File will be created locally in C:\Users\Public folder. Type in filename and Press Enter.");
          //  string filename = Console.ReadLine();
          //  StreamWriter file = new StreamWriter(@"C:\Users\Public\" + filename + ".gdbs");

          //  while (true)
           // {
            //    Console.WriteLine("TYPE 10 CARD VALUES and SPACE BETWEEN CARD VALUE." + "\r\n" + "PRESS ENTER to continue OR TYPE S and press Enter to exit.");
             //   string cardvalues = Console.ReadLine();
             //   if (cardvalues == "S") break;
             //   CardDeck cards = new CardDeck();  
             //   file.Write("set_10out " + CardDeck.getCardindex(cardvalues,cards) + "#  "+cardvalues+ "\r\n");
             //   Console.WriteLine("set_10out " + cards.temp+"\r\n");
       //   //  }
       // file.Close();

       // }
    }
}

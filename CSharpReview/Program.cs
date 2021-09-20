using System;
using System.Collections.Generic;

namespace A1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number of cards to pick: ");
			string line = Console.ReadLine();
			if (int.TryParse(line, out int numCards))
			{
				foreach (var card in CardPicker.PickSomeCards(numCards))
				{
					Console.WriteLine(card);
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
			}
		}
	}

	public static class SubsequenceFinder
	{
		/// <summary>
		/// Determines whether a list of integers is a subsequence of another list of integers
		/// </summary>
		/// <param name="seq">The main sequence of integers.</param>
		/// <param name="subseq">The potential subsequence.</param>
		/// <returns>True if subseq is a subsequence of seq and false otherise.</returns>
		public static bool IsValidSubsequeuce(List<int> seq, List<int> subseq)
		{

			//For loop going through all the values in seq stopping once there are not enough indexes left for subseq to fit
			for(int i = 0; i < (seq.Count - subseq.Count) + 1; i++)
            {
				bool check = true;
				//For loop going through all the values in subseq
				for (int j = 0; j < subseq.Count; j++)
                {
					//Console.Write("(" + subseq[j] + ", " + seq[i + j] + ") ");
					
					//starting at seq[i] (from the first loop) and adding j (from the current loop) each iteration to compare values
					//If they are not equal, set check to false and break to stop checking unneccesarily
					if (subseq[j] != seq[i + j])
                    {
						check = false;
						break;
                    }
                }
                //Console.WriteLine();

				//if check remained true (meaning that all the values from the check pass were matching) then return true 
				//Which also stops the function from continuing to check unneccesarily
				if (check) return true;
            }
			//if the entire seq list was checked and true was not returned, return false
			return false;
		}
	}

	class CardPicker
	{
		static Random random = new Random(1);
		/// <summary>
		/// Picks a random (with replacement) number of cards.
		/// </summary>
		/// <param name="numCards">The number of cards to choose at random.</param>
		/// <returns>An array of strings where each string represents a card.</returns>
		public static string[] PickSomeCards(int numCards)
		{
			// Use RandomValue() & RandomSuit() to help you here

			string[] cards = new string[numCards];
			for(int i = 0; i < numCards; i++)
            {
				cards[i] = RandomValue() + " of " + RandomSuit();
            }

			return cards;
		}
		/// <summary>
		/// Chooses a random value for a card (Ace, 2, 3, ... , Queen, King)
		/// </summary>
		/// <returns>A string that represents the value of a card</returns>
		private static string RandomValue()
		{
			string value = random.Next(1, 14).ToString();

			switch (value)
            {
				case "1":
					value = "Ace";
					break;
				case "11":
					value = "Jack";
					break;
				case "12":
					value = "Queen";
					break;
				case "13":
					value = "King";
					break;
            }
			return value;
		}
		/// <summary>
		/// Chooses a random suit for a card (Clubs, Diamonds, Hearts, Spades)
		/// </summary>
		/// <returns>A string that represents the suit of a card.</returns>
		private static string RandomSuit()
		{
			string suit = random.Next(1, 5).ToString();

            switch (suit)
            {
				case "1":
					suit = "Clubs";
					break;
				case "2":
					suit = "Diamonds";
					break;
				case "3":
					suit = "Hearts";
					break;
				case "4":
					suit = "Spades";
					break;
            }
			return suit;
		}
	}
}

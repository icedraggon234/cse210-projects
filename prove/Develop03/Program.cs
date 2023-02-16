using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();


        Reference reference = new Reference("Proverbs", 3, new int[] {5, 6});
        Scripture scripture = new Scripture(reference, new string[]
        {
            "Trust in the Lord with all thine heart and lean not unto thine own understanding.",
            "In all thy ways acknowledge him, and he shall direct thy paths."
        });

        

        

        




        ScriptureMemorization(scripture, 3);

        












        void ScriptureMemorization(Scripture scripture, int wordsToHideAtATime)
        {
            // made this into a function so one could more easily have the code do a different scripture

            List<Word> shownWords = new List<Word>();

            foreach (Verse verse in scripture.GetVerses())
            {
                foreach (Word word in verse.GetWords())
                {
                    shownWords.Add(word);
                }
            }

            string response;

            Console.Clear();
            DisplayScripture(scripture);
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();


                    

             while (response.ToLower() != "quit" && shownWords.Count() > 0)
            {
                HideRandomWords(shownWords, wordsToHideAtATime);
                Console.Clear();
                DisplayScripture(scripture);
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
                response = Console.ReadLine();


                


            }
        }



        void DisplayScripture(Scripture scripture)
        {
            Console.WriteLine(scripture.GetReference().GetReference());
            foreach (Verse verse in scripture.GetVerses())
            {
                foreach (Word word in verse.GetWords())
                {
                    Console.Write(word.GetWord()+" ");
                }
                Console.WriteLine();
            }
        }



        void HideRandomWords(List<Word> words, int numberOfWordsToHide)
        {
            // can only pick from words not alreadly hidden

            if (words.Count() < numberOfWordsToHide)
            {
                numberOfWordsToHide = words.Count();
            }

            int wordToHideIndex;
            for (int i = 0; i < numberOfWordsToHide; i++)
            {
                wordToHideIndex = randomGenerator.Next(words.Count());
                words[wordToHideIndex].HideWord();
                words.RemoveAt(wordToHideIndex);
            }
        }
    }
}
using System;
using System.Collections;

namespace POE_Part1
{
    public class CyberKoreBot
    {//start of class
        // Arrays to store answers and words to ignore
        ArrayList answers = new ArrayList();
        ArrayList ignore = new ArrayList();

        // Constructor to initialize the answers and ignored words
        public CyberKoreBot()
        {//start of constructor 

            // Add answers related to cybersecurity
            answers.Add("Password safety: Your password should be at least 8 characters long, using a mix of letters, numbers, and special characters.");
            answers.Add("Phishing: Be cautious about unsolicited emails or messages asking for personal details or financial information.");
            answers.Add("Safe browsing: Make sure the website has 'https' in the URL and avoid suspicious links.");
            answers.Add("I'm CyberKore, here to help you with cybersecurity basics!");
            answers.Add("My purpose is to answer questions related to password safety, phishing, and safe browsing. How can I help you?");
            answers.Add("Hello! How can I assist you today with cybersecurity concerns?");

            // Words to ignore in the user query (i.e., don't need responses based on these)
            ignore.Add("are");
            ignore.Add("you");
            ignore.Add("me");
            ignore.Add("about");
            ignore.Add("tell");
            ignore.Add("the");
        }//end of constructor

        // Method to start the chatbot and handle user interaction
        public void StartChat(string username)
        {//start of startchat method
            string ask = string.Empty;
            do
            {
                // Prompt the user for input
                Console.Write(username + ": ");
                ask = Console.ReadLine();

                // Validate input and provide response
                ProvideResponse(ask);
            } while (!ask.Equals("exit", StringComparison.OrdinalIgnoreCase)); // Exit the chat if user types "exit"
        }//end of startchat method

        // Method to process the user input and provide a response
        private void ProvideResponse(string ask)
        {//start of ProvideResponse method
            // Handle empty or invalid input
            if (string.IsNullOrWhiteSpace(ask))
            {
                Console.WriteLine("CyberKore: Please ask a valid question.");
                return;
            }

            // Split the input into words
            string[] words = ask.Split(' ');

            bool foundAnswer = false;

            // Check each word from the user input
            foreach (string word in words)
            {
                foreach (string answer in answers)
                {
                    // Check if any part of the answer contains the word and ensure it's not an ignored word
                    if (answer.ToLower().Contains(word.ToLower()) && !ignore.Contains(word.ToLower()))
                    {
                        // Respond with the corresponding answer
                        Console.WriteLine("CyberKore: " + answer);
                        foundAnswer = true;
                        break;
                    }
                }

                if (foundAnswer) break;
            }

            // Default response if no relevant answer is found
            if (!foundAnswer)
            {
                Console.WriteLine("CyberKore: I'm not sure about that. Could you ask something related to cybersecurity, like password safety or phishing?");
            }
        }//end of provideresponse method

    }
}
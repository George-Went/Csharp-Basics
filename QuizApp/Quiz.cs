using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    // Class Quiz contains an array of Question Classes
    internal class Quiz
    {
        private Question[] questions; // create array of questions 

        public Quiz(Question[] questions) // A Quiz object is a list of questions - each element in the lsit is called a question
        {
            this.questions = questions; // used to help define "question" as one var
        }

        public void RunQuiz()
        {
            int questionNumber = 1;
            foreach (Question question in questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question); // because its in the same class we can make DisplayQuestion private
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice)) // if answer number = user selected number
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    int correct_ans = question.CorrectAnswerIndex + 1; // index val of correct answer 
                    Console.WriteLine($"Incorrect, the answer was {correct_ans} {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
        }
        private void DisplayQuestion(Question question) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("    ");
                Console.Write($"{i + 1}. ");
                Console.ResetColor();
                Console.WriteLine($"{question.Answers[i]}");
            }

        }

        public int GetUserChoice()
        {
            Console.Write("Your answer (1-4): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine($"Choice : {choice}");
                Console.WriteLine("Invalid Choice. Please enter a number between 1 and 4");
                input = Console.ReadLine();
            }
            return (choice-1);
        }

    }

}

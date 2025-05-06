namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of the UK", // Question(question, answers[], int correctAnswerIndex)
                new string[] {"paris","london","berlin","tokyo"} // answers array
               ,1),// correctAnswerIndex (which one above in the array is correct

                new Question("What is 3 + 4", // Question(question, options[], int answer)
                new string[] {"5","4","6","7"}
               ,3)
            };
            Quiz myQuiz = new Quiz(questions);


            Console.WriteLine("Start Quiz ------------------------");
            myQuiz.RunQuiz();
            Console.WriteLine("End Quiz --------------------------");

        }
    }
}

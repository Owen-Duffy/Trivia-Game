using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame2
{
    class TriviaItem
    {

        string[] aryTriviaQuestion;
        string[] aryTriviaAnswer;

        public void setQuestions()
        {
            aryTriviaQuestion = new string[10];
            aryTriviaQuestion[0] = "What was the first video game?";
            aryTriviaQuestion[1] = "What is the name of the main character in Despicable Me?";
            aryTriviaQuestion[2] = "Which minion was knighted by Queen Elizabeth?";
            aryTriviaQuestion[3] = "What is the name for a group of crows?";
            aryTriviaQuestion[4] = "What is the name of the creator of this quiz?";
            aryTriviaQuestion[5] = "What is the first name of the main character in the original Star Wars trilogy?";
            aryTriviaQuestion[6] = "What real-life shipwreck inspired Moby Dick?";
            aryTriviaQuestion[7] = "What birds can find their way back to their nest from 1300 miles away?";
            aryTriviaQuestion[8] = "Who starts first in chess?";
            aryTriviaQuestion[9] = "What is the world's largest ocean?";
        }

        public void setAnswers()
        {
            aryTriviaAnswer = new string[10];
            aryTriviaAnswer[0] = "TENNIS FOR TWO";
            aryTriviaAnswer[1] = "GRU";
            aryTriviaAnswer[2] = "KEVIN";
            aryTriviaAnswer[3] = "A MURDER";
            aryTriviaAnswer[4] = "OWEN";
            aryTriviaAnswer[5] = "LUKE";
            aryTriviaAnswer[6] = "THE ESSEX";
            aryTriviaAnswer[7] = "PIGEONS";
            aryTriviaAnswer[8] = "WHITE";
            aryTriviaAnswer[9] = "PACIFIC";
        }

        public string getAnswer(int i)
        {
            return aryTriviaAnswer[i];
        }

        public string getQuestion(int i)
        {
            return aryTriviaQuestion[i];
        }
                
           
            
        
                
        
           
    }

}
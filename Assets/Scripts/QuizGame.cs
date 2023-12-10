using UnityEngine;
using UnityEngine.UI;

public class QuizGame : MonoBehaviour
{
    public class Question
    {
        public string questionText;
        public string[] answers;
        public int correctAnswerIndex;

        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            this.questionText = questionText;
            this.answers = answers;
            this.correctAnswerIndex = correctAnswerIndex;
        }
    }

    Question[] questions = new Question[] {
        new Question("What is the largest vein in the human body?", new string[] {"Pulmonary Vein", "Vena Cava", "Aorta", "Central Vein"}, 1),
        new Question("What is the primary function of the respiratory system?", new string[] {"Pump blood throughout the body"}, 0)
    };

    public Text questionText;
    public Button[] answerButtons;
    public int playerHealth = 100;
    public int enemyHealth = 100;
}

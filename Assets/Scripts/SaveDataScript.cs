using UnityEngine;
using UnityEngine.UI;

public class SaveDataScript : MonoBehaviour
{
    public InputField[] questionInputFields;
    public InputField[][] answerInputFields;
    public InputField[] correctAnswerIndexInputFields;
    public Button saveButton; // The button that will trigger the save

    void Start()
    {
        saveButton.onClick.AddListener(SaveData); // Subscribe SaveData to the button's onClick event
    }

    public void SaveData()
    {
        string allData = "";
        for (int i = 0; i < questionInputFields.Length; i++)
        {
            string questionText = questionInputFields[i].text;
            PlayerPrefs.SetString("QuestionText" + i, questionText);
            allData += "Question " + (i + 1) + ": " + questionText + "\n";
            for (int j = 0; j < answerInputFields[i].Length; j++)
            {
                string answerText = answerInputFields[i][j].text;
                PlayerPrefs.SetString("Answer" + i + "_" + j, answerText);
                allData += "Answer " + (j + 1) + ": " + answerText + "\n";
            }
            int correctAnswerIndex = int.Parse(correctAnswerIndexInputFields[i].text);
            PlayerPrefs.SetInt("CorrectAnswerIndex" + i, correctAnswerIndex);
            allData += "Correct Answer: " + correctAnswerIndex + "\n";
        }
        PlayerPrefs.SetString("AllData", allData);
        PlayerPrefs.Save();
    }
}
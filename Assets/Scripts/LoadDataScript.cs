using UnityEngine;
using UnityEngine.UI;

public class LoadDataScript : MonoBehaviour
{
    public Text dataText; // Reference to the Text component of your textbox

    void Start()
    {
        LoadData();
    }

    public void LoadData()
    {
        string allData = PlayerPrefs.GetString("AllData"); // Get the saved data
        dataText.text = allData; // Set the text of the Text component to the saved data
    }
}
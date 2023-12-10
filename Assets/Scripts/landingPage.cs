using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LandingPage : MonoBehaviour
{
    public InputField classCodeInput;
    public Button joinButton;

    void Start()
    {
        joinButton.onClick.AddListener(OnJoinButtonClick);
    }

    void OnJoinButtonClick()
    {
        if (classCodeInput.text == "1234")
        {
            SceneManager.LoadScene("Student Teacher Login");
        }
    }
}
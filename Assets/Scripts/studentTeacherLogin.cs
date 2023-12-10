using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StudentTeacherLogin : MonoBehaviour
{
    public InputField NameInput;
    public Button joinButton1;
    public Button joinButton2;

    void Start()
    {
        joinButton1.onClick.AddListener(OnJoinButton1Click);
        joinButton2.onClick.AddListener(OnJoinButton2Click);
    }

    void OnJoinButton1Click()
    {
        SceneManager.LoadScene("Student Game");  // replace GameScene1 with the name of your first game scene
    }

    void OnJoinButton2Click()
    {
        SceneManager.LoadScene("Teacher Dashboard");  // replace GameScene2 with the name of your second game scene
    }
}
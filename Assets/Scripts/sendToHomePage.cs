using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sendToHomePage : MonoBehaviour
{

    public Button submitButton;
    // Start is called before the first frame update
    void Start()
    {
        submitButton.onClick.AddListener(submitButtonOnClick);
    }

    // Update is called once per frame
    void submitButtonOnClick () {
        SceneManager.LoadScene("landingPage");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    // singleton pattern
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GoToClass() // temporary function while fixes are being made
    {
        Score.Instance.points = 0;
        SceneManager.LoadScene("QuizQuestion1");
    }

    public void StartGame()
    {
        Score.Instance.points = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false; // allow quit functionality when editing
    }
}

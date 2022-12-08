using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizScore : MonoBehaviour
{
    public static QuizScore instance;
    public Text score, message;
    public int points = 0;
    public const int MAX_POINTS = 6;

    void Start()
    {
        Refresh();
    }

    void Refresh()
    {
        score.text = points + "/" + MAX_POINTS;
        if (points <= 3)
            message.text = "You failed, but you can try again!";
        else if (points > 3 && points <= 5)
            message.text = "You passed. Good job!";
        else
            message.text = "Perfect score! You did amazing!";
    }

    // create singleton to ensure only one of these exists at one time
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

    public void ChooseCorrect()
    {
        points += 1;
        Refresh();
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    public void ChooseIncorrect()
    {
        Refresh();
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizScore : MonoBehaviour
{
    
    public Text score, message;
    public const int MAX_POINTS = 6;


    void Start()
    {
        Refresh();
    }

    void Refresh()
    {
        score.text = Score.Instance.points + "/" + MAX_POINTS;
        if (Score.Instance.points <= 3)
            message.text = "You failed, but you can try again!";
        else if (Score.Instance.points > 3 && Score.Instance.points <= 5)
            message.text = "You passed. Good job!";
        else
            message.text = "Perfect score! You did amazing!";
    }

    public void ChooseCorrect()
    {
        Score.Instance.points += 1;
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
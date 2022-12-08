using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultScreen : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI message;
    public const int MAX_POINTS = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
}

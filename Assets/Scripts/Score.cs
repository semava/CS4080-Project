using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    private static Score _instance;
    public int points = 0;
    public static Score Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Score>();
                if (_instance == null)
                {
                    _instance = new GameObject().AddComponent<Score>();
                }
            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance != null)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);

    }

}

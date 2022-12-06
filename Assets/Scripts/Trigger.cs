using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    
public abstract class Trigger : MonoBehaviour
{

    public bool t;
    public string s = "default";




    void OnTriggerEnter2D(Collider2D col)
    {

        t = true;
    }


    void OnTriggerStay2D(Collider2D col)
    {
        t = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        t = false;
    }

    


}

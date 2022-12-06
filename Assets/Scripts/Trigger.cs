using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    
public class Trigger : MonoBehaviour
{

    public bool Triger;



    void OnTriggerEnter2D(Collider2D col)
    {

        Triger = true;
    }


    void OnTriggerExit2D(Collider2D col)
    {
        Triger = false;
    }

    


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bookcase2 : MonoBehaviour
{
    public BoxCollider2D box;
    public Canvas image;
    protected bool ShowUI = false;
    public Trigger t;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && t.Triger)
        {
            ShowUI = true;
            print("yes2");
        }

        if (ShowUI && t.Triger)
        {
            image.enabled = true;
        }
        if (!t.Triger)
        {
            ShowUI = false;
            image.enabled = false;
        }
    }

}

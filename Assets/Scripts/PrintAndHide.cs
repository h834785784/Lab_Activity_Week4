using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    public GameObject objname;
    private int i;
    public Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        Debug.Log(objname.name+":"+i);
    }
}

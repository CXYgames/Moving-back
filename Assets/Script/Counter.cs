using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    static int skipcounter=0;
    // Start is called before the first frame update
    void Start()
    {
        skipcounter = skipcounter + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //guiText.text = skipcounter.ToString();
    }
}

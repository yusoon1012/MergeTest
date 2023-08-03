using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    public int Plus;
    public int number = 1;

    public int number22 = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Plus = number* number22;
        Debug.LogFormat("{0}", Plus);
    }
}

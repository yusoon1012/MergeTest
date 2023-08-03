using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour
{
    public float number = 10f;
    public int intNum = 3;
    public int Plus;
    

    public int number22 = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Plus = (int)number* number22;
        Debug.LogFormat("{0}", Plus);
    }
}

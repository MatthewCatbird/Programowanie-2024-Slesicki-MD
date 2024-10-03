using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
        transform.Translate(0.001f,0,0);
    }
}

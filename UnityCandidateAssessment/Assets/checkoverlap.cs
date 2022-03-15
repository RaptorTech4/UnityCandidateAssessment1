using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkoverlap : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Started overlap");
    }

    private void OnTriggerExit(Collider other)
    {
        print("Ended overlap");
    }
}

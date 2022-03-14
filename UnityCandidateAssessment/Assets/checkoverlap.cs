using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkoverlap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

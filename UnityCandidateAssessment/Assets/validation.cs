using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class validation : MonoBehaviour
{
    public GameObject param1, param2, param3, param4;

    void Start()
    {
        if (param1 != null) {
            if (param2 != null) {
                bool stuffDone = DoSomeStuff(param1, param2);

                if (param3 != null) {
                    GameObject newObject = DoMoreStuff(param3);

                    if (param4 != null) {
                        print("Success");
                    } else {
                        Debug.LogError("Reference invalid");
                    }
                } else {
                    Debug.LogError("Reference invalid");
                }
            } else {
                Debug.LogError("Reference invalid");
            }
        } else {
            Debug.LogError("Reference invalid");
        }
    }

    private bool DoSomeStuff(GameObject param1, GameObject param2)
    {
        return true;
    }

    private GameObject DoMoreStuff(GameObject go)
    {
        return GameObject.Instantiate(go);
    }
}

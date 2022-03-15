using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class validation : MonoBehaviour
{
    public GameObject param1, param2, param3, param4;

    void Start()
    {
        #region original
        if (param1 != null) 
        {
            if (param2 != null) 
            {
                bool stuffDone = DoSomeStuff(param1, param2);

                if (param3 != null) 
                {
                    GameObject newObject = DoMoreStuff(param3);

                    if (param4 != null) 
                    {
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
        #endregion

        #region notes
        /*
         * 
        This problem is a difficult one to take because I'm missing context on how this 
        script is used. Depending on how it is used will define the way the code needs to be layout. 

        One of the things that I picked up on is the variables that you created are never used.
        Another thing is the location of where the variables are created. It's not wise to create
        a variable inside a null method because if the variable is used somewhere outside of the 
        null method but still at the start it will create a lot of problems and errors. 
        You will not be able to assess the variable outside of the method at all. If that is 
        the way it was intended then it will work just fine.

        The Debug.LogError is used in the appropriate locations in your original code but the 
        problem I have is that the information that it is logging is missing crucial info. 
        It only says that there is something wrong it does not specify the location and also not
        the reason for why something is wrong.

        If I'm missing something that might be missing or wrong please let me know otherwise 
        I don't see anything wrong with the code if you need to use it in this context.

         * 
         */
        #endregion notes

        #region My methods

        #region Method 1

        #region notes

        /*
         * 
        This is one method of doing a null check if you just want to check the indefinite 
        variables where it's needed. If one of the variables is missing it will not complete 
        that variable's task but it will also not stop the rest of the variables that do 
        have references from doing their tasks.
         * 
         */

        #endregion notes

        if (param1 != null && param2 != null)
        {
            bool stuffDone = DoSomeStuff(param1, param2);
        }
        else
        {
            Debug.LogError("param1 or param2 Reference is invalid or missing");
        }

        if (param3 != null)
        {
            GameObject newObject = DoMoreStuff(param3);
        }
        else
        {
            Debug.LogError("param3 Reference is invalid or missing");
        }

        if (param4 != null)
        {
            print("Success");
        }
        else
        {
            Debug.LogError("param4 Reference is invalid or missing");
        }
        #endregion Method 1

        #region Method 2

        #region notes

        /*
         * 
        This is another method that will check if all the variables have 
        a reference before it does all the task that is needed.
         * 
         */

        #endregion notes

        if (param1 != null && param2 != null && param1 != null && param2 != null)
        {
            bool stuffDone = DoSomeStuff(param1, param2);
            GameObject newObject = DoMoreStuff(param3);
            print("Success");
        }
        else
        {
            Debug.LogError("One or more references are invalid or missing.");
        }

        

        #endregion Method 2

        #endregion My methods
    }

    private bool DoSomeStuff(GameObject param1, GameObject param2)
    {
        return true;
    }
    #region notes
    /*
     * 
    This variable will never be false because there is no condition to make 
    it false and also when the bool is created at the top it does not start 
    out as false and then turns true. So the variable will always be true no 
    matter what the conditions are in this case.

    Another method you can use was to add the null reference in this method. 
    It will check if it was null or not. Then their wood have been a true or false return.
     * 
     */
    #endregion notes

    private GameObject DoMoreStuff(GameObject go)
    {
        return GameObject.Instantiate(go);
    }

    #region notes
    /*
     * 
    As for the Instantiate itself, there is no reference to the position 
    or rotation of the object when you instantiate it.
    So it will just instantiate the object at the location of the prefab 
    local location. So the X Y Z of the prefab world will line up to the 
    global X Y Z location. In some scenarios that will be best especially 
    if you loading in a world, but again I have no context of how the code
    is being used or an example of the code in action this is why I'm having 
    trouble with this one.
     * 
     */
    #endregion notes

}

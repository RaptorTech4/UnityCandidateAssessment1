using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssessmentNotes : MonoBehaviour
{
    #region Problem 1 Notes
    /*
     * 
     * Problem 1: .gitignore.
        When it comes to making a .gitignore file. I normally create it when I 
        create the project so I have never really made one from scratch. I 
        search for one GitHub and the example one was fine but it included 
        too much data that you don't need like case data and crash log data. 
        I removed all the data that was not needed from the list using one 
        of my former .gitignore files. I hope this will do it for you.
     * 
     */
    #endregion Problem 1 Notes

    #region Problem 2 Notes

    /*
     * Notes in validation script and sorry for all the long paragraphs. I was not 
        able to complete this Problem the explanation is in the script. 
     */

    #endregion Problem 2 Notes

    #region Problem 3 Notes
    /*
     * 
      Problem 3: VR Controls.
        One of the fings I love the most about the XR package is that most of 
        the basic mechanics are already scripted. All you have to do is find the 
        methods you want to use and add the script to the right game object. 
        After adding the scripts you just have to fill in the missing information.

        When it came to the rotation part you did not specify which method you wanted. 
        I added a snap turn because a lot fewer people get sick when they use that method.
     * 
     */
    #endregion Problem 3 Notes

    #region Problem 4 Notes
    /*
     * 
        Problem 4: Physics interaction.
        When you are trying to make a tiger function OnTriggerEnter or OnTriggerExit 
        you need the following parameters to be true. Make sure that the game object with 
        the script has some form of collider on it. make sure that the collider is set 
        as a trigger. Make sure the script is on the game object. Make sure that the game 
        object that you want to use has a collider on it as well. make sure the game object
        that you're using to collide with the trigger has a rigidbody on it. and make sure 
        layer masks one both objects can interact with ith other. If using tags make sure the 
        tags are assigned to the right objects.

     *ignore this note i read the question wrong but i fixed it

        For this particular project, it's not just as simple as adding a rigidbody and a collider
        to the hand. you have to deactivate using gravity. You also have to make sure that the 
        Raycast interaction that is used for UI does not interact with the collider on the hand.
        The best way to do that is using the layer mask and assigning the raycast to only interact
        with objects in that layer mask. You also have to go into the project settings under physics
        and make it that the layer mask can only interact with itself and not other objects under 
        different layer masks.

        I changed the raycast to only interact with the UI layer mask and so all UI elements will 
        have to be under one layer mask. you can also change the position of where the raycast begins
        outside of the collider if you want to use the raycast in multiple ways.

     *ignore this note i read the question wrong but i fixed it
     * 
     */
    #endregion Problem 4 Notes
}

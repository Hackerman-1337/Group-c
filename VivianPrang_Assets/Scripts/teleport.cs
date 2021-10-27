using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleportTarget; //The variable for the teleport position
    public GameObject thePlayer; //the variable for the teleporting player

    void OnTriggerEnter(Collider other) //setting the trigger for teleportation
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        //The trigger makes one position equal the other
    }
}

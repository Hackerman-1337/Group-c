using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{   
    [SerializeField]
    GameObject door;

    bool Open = false;


    void OnTriggerEnter(Collider Player)
    {
        if (!Open)
        {
            Open = true;
            door.transform.position -= new Vector3(0, 10, 0);
        }
    }

}

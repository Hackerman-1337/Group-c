using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorway : MonoBehaviour
{
	public int row;
	public int doorNumber;
	bool rightDoor = false;
	public GameObject room;	
	public GameObject tablet;

    // Start is called before the first frame update
    void Start()
    {
		if (room.GetComponent<setupSpeedRoom>().openDoorways[row] == doorNumber) { 
			rightDoor = true;
		}	
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	void OnTriggerEnter(Collider other)
	{		
		if (rightDoor){
			Destroy(this.gameObject);
			if (row != 5)
				tablet.GetComponent<tablet>().changeTablet(row+3);
			else
				Destroy(tablet.gameObject);
		}
	}
}

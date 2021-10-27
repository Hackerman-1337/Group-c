using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
	public int row;
	public int platformNumber;
	bool rightPlatform = false;
	public GameObject room;	
	public GameObject tablet;

    // Start is called before the first frame update
    void Start()
    {
		if (room.GetComponent<setupAccuracyRoom>().solidPlatforms[row] == platformNumber) { 
			rightPlatform = true;
		}	
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	void OnTriggerEnter(Collider other)
	{
		if (!rightPlatform){
			Destroy(this.gameObject);
		}
		else
			tablet.GetComponent<tablet>().changeTablet(row);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setupSpeedRoom : MonoBehaviour
{
	public int[] openDoorways = new int[6];
	System.Random random = new System.Random();
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
		for (int i = 0; i<6; i++)
			openDoorways[i] = random.Next(0, 4);	
    }
}

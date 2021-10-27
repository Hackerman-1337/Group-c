using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setupAccuracyRoom : MonoBehaviour
{
	public int[] solidPlatforms = new int[3];
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
		for (int i = 0; i<3; i++)
			solidPlatforms[i] = random.Next(0, 4);
		
		/*
		for (int i = 0; i<3; i++){
			Debug.Log("i = " + i + " num= " + solidPlatforms[i]);
		}
		 */	
    }
}

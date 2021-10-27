using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablet : MonoBehaviour
{
	public bool[] colorChange = new bool[9];
	public Material[] tabletColor = new Material[9]; 
	public GameObject accuracyRoom;
	public GameObject speedRoom;
	public Material blue;
	public Material green;
	public Material red;
	public Material yellow;
	int tabletColorIndex;
	
	void fillTabletColor(int number){
		switch (number)
		{
			case 0:
				tabletColor[tabletColorIndex] = blue;
				break;
			case 1:
				tabletColor[tabletColorIndex] = green;			
				break;
			case 2:
				tabletColor[tabletColorIndex] = red;			
				break;
			case 3:
				tabletColor[tabletColorIndex] = yellow;				
				break;
		}
	}
	
	public void changeTablet(int index){
		if (!colorChange[index])
			GetComponent<MeshRenderer>().material = tabletColor[index+1];
		colorChange[index] = true;
		
	}
	
    // Start is called before the first frame update
    void Start()
    {
    	tabletColorIndex = 0;
    	
		for (int i = 0; i < 9; i++){
			colorChange[i] = false;
		}  
		
		for (int i = 0; i < 3; i++){
			fillTabletColor(accuracyRoom.GetComponent<setupAccuracyRoom>().solidPlatforms[i]);
			tabletColorIndex++;
		}
		
		for (int i = 0; i < 6; i++){
			fillTabletColor(speedRoom.GetComponent<setupSpeedRoom>().openDoorways[i]);
			tabletColorIndex++;
		}
		
		GetComponent<MeshRenderer>().material = tabletColor[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

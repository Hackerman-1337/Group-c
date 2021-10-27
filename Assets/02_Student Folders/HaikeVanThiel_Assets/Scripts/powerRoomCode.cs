using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerRoomCode : MonoBehaviour
{
    public GameObject bot;
    public Material material;
    public int numBot;
    public GameObject lootHealth;
    public GameObject respawnEnemy;
    bool killed;
    static int numKill;
    
    //Handles when bot is killed in the right order
    void GoodKill()
    {
    	numKill = numBot;
    	killed = true;
		bot.GetComponent<EnemyController>().lootPrefab = lootHealth;
		GetComponent<MeshRenderer>().material = material;
		bot.GetComponent<Health>().Kill();
    }
    
    //Handles when bot is killed in the wrong order
    void BadKill()
    {
    	bot.GetComponent<Health>().currentHealth = 91f;
    	killed = false;
    }
	
	//initialize variables at start
    void Start()
    {
		killed = false;
        numKill = 0;
    }

    // Update is called once per frame
    void Update()
    {
    	if (!killed){
		    if (bot.GetComponent<Health>().currentHealth <= 1f){
                switch(numKill)
				{
					case 0:
						if (numBot == 1)
							GoodKill();
						else
							BadKill();
						break;
					case 1:
						if (numBot == 2)
							GoodKill();
						else 
							BadKill();
						break;
					case 2:
						if (numBot == 3)
							GoodKill();
						else 
							BadKill();
						break;
					case 3:
						if (numBot == 4){
							GoodKill();
							Destroy(GameObject.Find("powerPassage"));
						}
						else 
							BadKill();
						break;
				}//switch
		    }//if bot dies
        } //check kill   
    }
}



    

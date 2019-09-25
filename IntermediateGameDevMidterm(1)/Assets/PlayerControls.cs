using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public GameObject NPC;
    public bool hasCassette = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        //If Player Collides into button1 and hasn't collided into a button yet
        //Play Friends by twin Xl
        //CassetteTurnsTrue();
        //Get a cassette of button's color
        
        //If Player Collides into button2and hasn't collided into a button yet
        //Play BleedMagic by iDKHOW
        //CassetteTurnsTrue();
        //Get a cassette of button's color
        
       
        //If Player Collides into button3
        //Play 
        //CassetteTurnsTrue();
        //Get a cassette of button's color


        //If Player Collides into Npc
        //Trigger On NPC For Cassette
    }

   /* public void OnNPC()
    {
        if(hascassette == true)
        {
        }
        
        
    }*/
   
   /* public void CassetteTurnsTrue ()
    {
    
        //Disable All Buttons
        //hasCassette == true;
        
        
    }*/
}

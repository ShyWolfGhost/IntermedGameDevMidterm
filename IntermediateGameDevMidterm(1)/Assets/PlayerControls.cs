﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Player Motion Controls
    public float moveSpeed = 3f;
    public Vector3 inputVector;
    public Rigidbody thisRigidbody;
    
    
   

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    //public AudioSource Source;
    //public AudioClip button1Clip;
    //public AudioClip button2Clip;
    //public AudioClip button3Clip;

    //public GameObject NPC;
    public bool hasCassette = false;

    //public TextMesh Mesh;
    
    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>(); 
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        inputVector = transform.forward * vertical;
        inputVector += transform.right * horizontal;
        

    }

    void FixedUpdate()
    {
        thisRigidbody.velocity = inputVector * moveSpeed + Physics.gravity * .69f;
    }

  

    void OnTriggerEnter(Collider other)
    {
    
    //Make cassette Sprite enabled,Change color Per Button
    //Text, Think of when you want them to appear
    if (other.name=="button1")
    {
        Debug.Log("BUTTON 1 FRIENDS");
        CassetteTurnsTrue();
        
    }
    if (other.name=="button2")
    {
        Debug.Log("BUTTON 2 BLEED MAGIC");
        CassetteTurnsTrue();
        
    }
    if (other.name=="button3")
    {
        Debug.Log("BUTTON 3 ????");
        CassetteTurnsTrue();
        
    }
        
    //If Player Collides into button1 and hasn't collided into a button yet
        //Dark Blue Button
        //Play Friends by twin Xl
        //Source.PlayOneShot(button1Clip);
        //CassetteTurnsTrue();
        //Get a cassette of button's color
        //"Acheivement Unlocked: Friends By TwinXL, Go share it"
        
        //If Player Collides into button2and hasn't collided into a button yet
        //Orange Button
        //Play BleedMagic by iDKHOW
        //Source.PlayOneShot(button2Clip);
        //CassetteTurnsTrue();
        //Get a cassette of button's color
        //"Acheivement Unlocked: Bleed Magic By i DONT KNOW HOW BUT THEY FOUND ME, Go share it"
        
       
        //If Player Collides into button3
        //Color Button
        //Play (one night by the summerset Or Emily by catfish) (idk the color)
        //Source.PlayOneShot(button3Clip); 
        //CassetteTurnsTrue();
        //Get a cassette of button's color
        //"Acheivement Unlocked: ______ By ______, Go share it"


        //If Player Collides into Npc
        //Trigger On NPC For Cassette
    }

   /* public void OnNPC()
    {
        if(hascassette == true)
        {
        //Do I want Cassette Specific Dialouge?
        //"Meh"
        }
        
        
    }*/
   
    public void CassetteTurnsTrue ()
    {
    
        //Disable All Buttons
        hasCassette = true;
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        Debug.Log("all Gone");
        
        
        
    }
}

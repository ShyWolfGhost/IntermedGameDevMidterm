using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Player Motion Controls
    public float moveSpeed = 3f;
    public Vector3 inputVector;
    public Rigidbody thisRigidbody;
   

    //public GameObject button1;
    //public GameObject button2;
    //public GameObject button3;

    //public GameObject NPC;
    //public bool hasCassette = false;
    
    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>(); 
        
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
    
    /*void OnCollisionEnter(Collision other)
    {
        //If Player Collides into button1 and hasn't collided into a button yet
        //Dark Blue Button
        //Play Friends by twin Xl
        //CassetteTurnsTrue();
        //Get a cassette of button's color
        
        //If Player Collides into button2and hasn't collided into a button yet
        //Orange Button
        //Play BleedMagic by iDKHOW
        //CassetteTurnsTrue();
        //Get a cassette of button's color
        
       
        //If Player Collides into button3
        //Color Button
        //Play 
        //CassetteTurnsTrue();
        //Get a cassette of button's color


        //If Player Collides into Npc
        //Trigger On NPC For Cassette
    }*/

   /* public void OnNPC()
    {
        if(hascassette == true)
        {
        //Do I want Cassette Specific Dialouge?
        }
        
        
    }*/
   
   /* public void CassetteTurnsTrue ()
    {
    
        //Disable All Buttons
        //hasCassette == true;
        
        
    }*/
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    public GameObject blue;
    public GameObject yellow;
    
    //Player Motion Controls
    public float moveSpeed = 3f;
    public Vector3 inputVector;
    public Rigidbody thisRigidbody;


    public AudioClip Distortedbumble;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public AudioSource Source;
    public AudioClip button1Clip;
    public AudioClip button2Clip;
    public AudioClip button3Clip;
    public AudioClip OnNPCaudio;

    //public GameObject NPC;
    public bool hasCassette = false;
    public int Trials = 0;
    public bool XLcollide = false;
    public bool iDKcollide = false;
    public bool Questcollide = false;
    public GameObject cassette1;
    public GameObject cassette2;
    public GameObject cassette3;


    public bool ENDING = false;
    //DOES THE NPC NEED A PHYSICAL CASSETTE?????
    //public GameObject NPCcassette1;
    //public GameObject NPCcassette2;
    //public GameObject NPCcassette3;

    public Text Meshy;
    
    // Start is called before the first frame update
    void Start()
    {
        Source.Play();
        blue.SetActive(false);
        yellow.SetActive(false);
        thisRigidbody = GetComponent<Rigidbody>(); 
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        cassette1.SetActive(false);
        cassette2.SetActive(false);
        cassette3.SetActive(false);
        //NPCcassette1.SetActive(false);
        //NPCcassette2.SetActive(false);
        //NPCcassette3.SetActive(false);
        Meshy.text = "ACHIEVEMENT UNLOCKED: WELCOME TO THE WORLD, STARS ARE JUST STARS AND THAT’S IT. GO ACQUIRE MORE KNOWLEDGE!!!";


    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        inputVector = transform.forward * vertical;
        inputVector += transform.right * horizontal;
        
        if (ENDING==true&&Input.GetKey(KeyCode.Space))
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index) ;
            Debug.Log("Mischeif Managed input done");
        }
        

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
        
        
        Source.PlayOneShot(button1Clip);
        Debug.Log("BUTTON 1 FRIENDS");
        XLcollide = true;
        cassette1.SetActive(true);
        Meshy.text = "ACHIEVEMENT UNLOCKED: LEARNED FRIENDS BY TWIN XL. GO SHARE IT WITH THE MASSES!!!";
        blue.SetActive(true);
        
        CassetteTurnsTrue();
        
    }
    if (other.name=="button2")
    {
        Source.PlayOneShot(button2Clip);
        Debug.Log("BUTTON 2 BLEED MAGIC");
        iDKcollide = true;
        Meshy.text = "ACHIEVEMENT UNLOCKED: LEARNED BLEED MAGIC BY I DONT KNOW HOW BUT THEY FOUND ME. GO SHARE IT WITH THE MASSES!!!";
        cassette2.SetActive(true);
        
        CassetteTurnsTrue();
        
    }
    if (other.name=="button3")
    {
        Source.PlayOneShot(button3Clip);
        Debug.Log("BUTTON 3 ????");
        Questcollide = true;
        cassette3.SetActive(true);
        Meshy.text = "ACHIEVEMENT UNLOCKED: LEARNED SOUNDCHECK BY CATFISH AND THE BOTTLEMEN. GO SHARE IT WITH THE MASSES!!!";
        yellow.SetActive(true);
        CassetteTurnsTrue();
        
    }
    
    if (other.name=="Npc1")
    {
        OnNPC();

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

    public void OnNPC()
    {
        if(hasCassette == false)
        {
            Meshy.text = "... ... ... ... ... ... ... ...";
            //PLAY FINAL FANTASY VICTORY HORNS YOOOOOO
            //Do I want Cassette Specific Dialouge?
            //"Meh"
        }
        
        if(hasCassette == true)
        {
            Source.PlayOneShot(OnNPCaudio);
            cassette1.SetActive(false);
            cassette2.SetActive(false);
            cassette3.SetActive(false);
            if (Trials == 1)
            {
                Meshy.text = "ACHIEVEMENT UNLOCKED: LEARNED NPC1 IS BUSY!!! TRY AGAIN?";
                ButtonCollideCheckXL();
                ButtonCollideCheckiDK();
                ButtonCollideCheckQuest();
                hasCassette = false;
            }
            if (Trials == 2)
            {
                Meshy.text = "ACHIEVEMENT UNLOCKED: LEARNED NPC1 HAS NO RESPONSE!!! TRY AGAIN?";
                ButtonCollideCheckXL();
                ButtonCollideCheckiDK();
                ButtonCollideCheckQuest();
                hasCassette = false;
            }
            if (Trials == 3)
            {
                //Meshy.text = "ACHIEVEMENT UNLOCKED: LEARNED NO ONE CARES ABOUT YOUR INTERSTS!!!";
               Debug.Log("ending goes here, press space to reset scene");
               FuckYOU();
            }
            
            //PLAY FINAL FANTASY VICTORY HORNS YOOOOOO
            //Do I want Cassette Specific Dialouge?
            //"Meh"
        }
        
        
        
    }
   
    public void CassetteTurnsTrue ()
    {
    
        //Disable All Buttons
        Trials = Trials + 1 ;
        hasCassette = true;
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        Debug.Log("all Gone");
        
        
        
    }

    public void ButtonCollideCheckXL()
    {
        if (XLcollide == false)
        {
            button1.SetActive(true);
        }

        if (XLcollide == true)
        {
            button1.SetActive(false);
        }
        
    }
    public void ButtonCollideCheckiDK()
    {
        if (iDKcollide == false)
        {
            button2.SetActive(true);
        }

        if (iDKcollide == true)
        {
            button2.SetActive(false);
        }
        
    }
    public void ButtonCollideCheckQuest()
    {
        if (Questcollide == false)
        {
            button3.SetActive(true);
        }

        if (Questcollide == true)
        {
            button3.SetActive(false);
        }
        
    }
    public void FuckYOU()
    {
        Meshy.text = "ACHIEVEMENT UNLOCKED: LEARNED NO ONE CARES ABOUT YOUR INTERSTS!!! MAYBE NEXT TIME WILL BE DIFFERENT??? PRESS SPACE TO FIND OUT!!!";
        Debug.Log("Mischeif Managed");
        ENDING = true;
        
    }
    

}

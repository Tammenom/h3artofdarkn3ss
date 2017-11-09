using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skipperdialogscript01 : MonoBehaviour {


    
    private DialogueManager dMAn;


    public string[] dialogueLines0;
    public string[] dialogueLines1;
    public string[] dialogueLines2;
    public string[] dialogueLines3;
    private dialogturn01 sdialogevent;
    public int dialogEvent;

    // Use this for initialization
    void Start()
    {
        dMAn = FindObjectOfType<DialogueManager>();
        dialogEvent = 0;
        dialogueLines0 = new string[3];
        dialogueLines1 = new string[2];
        dialogueLines2 = new string[4];
        dialogueLines3 = new string[1];



            dialogueLines0[0] = "bonjour";
        dialogueLines0[1] = "baguette?";
        dialogueLines0[2] = "formage";

        dialogueLines1[0] = "Hello";
            dialogueLines1[1] = "Im the skipper";
        

       

            dialogueLines2[0] = "yes";
            dialogueLines2[1] = "Im the skipper";
            dialogueLines2[2] = "wazzup";
            dialogueLines2[3] = "cool cool";
      

            dialogueLines3[0] = "yeah yeah whats so ever";

        

    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //dMAn.ShowBox(dialogue);

                if (!dMAn.dialogActive)
                {
                    if (dialogEvent == 0) { 
                        dMAn.dialogLines = dialogueLines0;
                    }
                    if (dialogEvent == 1)
                    {
                        dMAn.dialogLines = dialogueLines1;
                    }
                    if (dialogEvent >=2)
                    {
                        dMAn.dialogLines = dialogueLines2;
                    }


                    dMAn.currentLine = 0;
                    dMAn.ShowDialogue();
                }

                //if(transform.parent.GetComponent<>)
            }
        }
    }
}


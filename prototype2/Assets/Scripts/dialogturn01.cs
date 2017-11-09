using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogturn01 : MonoBehaviour {

    public skipperdialogscript01 skipperdia;

    // Use this for initialization
    void Start () {

       
        skipperdia = FindObjectOfType<skipperdialogscript01>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            skipperdia.dialogEvent++;
        }
    }

    
}


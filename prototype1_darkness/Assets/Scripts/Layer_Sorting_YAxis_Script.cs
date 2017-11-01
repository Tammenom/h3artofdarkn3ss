using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer_Sorting_YAxis_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
            GetComponent<SpriteRenderer>().sortingOrder = -(int)(transform.position.y * 100);
        
    }
}

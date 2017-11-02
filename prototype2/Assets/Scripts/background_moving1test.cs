using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_moving1test : MonoBehaviour {

    private Vector3 targetPos;
    private Vector3 newVector;
    public float picmax;
    public float picmin;

    public float moveSpeed;
    public float groundMoveSpeed;
    private float xCorrection;

    // Use this for initialization
    void Start () {
        xCorrection = groundMoveSpeed;
	}
	
	// Update is called once per frame
	void Update () {

        

        targetPos = new Vector3(transform.position.x + xCorrection, transform.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);

        if(transform.position.x >= picmax)
        {
            newVector = new Vector3(-picmin, transform.position.y, transform.position.z);

            transform.position = newVector;

            xCorrection = groundMoveSpeed;


        }
    }
}

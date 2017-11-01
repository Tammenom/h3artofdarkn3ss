using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipperController : MonoBehaviour {

    public float horSpeed;
    public float verSpeed;

    private Rigidbody2D skiRigidbody;

    private bool moving;

    public float timeBetweenMove;
    private float timeBetweenMoveCounter;
    public float timeToMove;
    public float timeToMoveCounter;
    private Vector3 moveDirection;


	// Use this for initialization
	void Start () {

        skiRigidbody = GetComponent<Rigidbody2D>();

		
	}
	
	// Update is called once per frame
	void Update () {

        if (moving)
        {
            timeToMoveCounter -= Time.deltaTime;
            skiRigidbody.velocity = moveDirection;

            if(timeToMoveCounter<0f)
            {
                moving = false;
                timeBetweenMoveCounter = timeBetweenMove;
            }




        }
        else
        {
            timeBetweenMoveCounter -= Time.deltaTime;
            skiRigidbody.velocity = Vector2.zero;

            if(timeBetweenMoveCounter < 0f)
            {
                moving = true;
                timeToMoveCounter = timeToMove;

                moveDirection = new Vector3(Random.Range(-1f, 1f) *horSpeed, Random.Range(-1f, 1f)*verSpeed, 0f);
            }


        }
		
	}
}

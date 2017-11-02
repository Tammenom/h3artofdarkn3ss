using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float moveSpeed;
    public float upDownSpeed;

    private Animator anim;
    private Rigidbody2D playerRigidBody;

    private bool PlayerMovingHorizontal;
    private bool PlayerMovingVertical;
    private float LastMove;

    private static bool playerExists = false;


    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody2D>();

        if (!playerExists)
        {
            
            DontDestroyOnLoad(transform.gameObject);
            playerExists = true;
        } else
        {
            Destroy(gameObject);
        }

	}
	
	// Update is called once per frame
	void Update () {

        PlayerMovingHorizontal = false;
        PlayerMovingVertical = false;


        if (Input.GetAxisRaw("Horizontal")> 0.5f || Input.GetAxisRaw("Horizontal") < -0.5)
        {
            //transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, playerRigidBody.velocity.y);
            PlayerMovingHorizontal = true;
            LastMove = Input.GetAxisRaw("Horizontal");
        }


        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5)
        {
            //transform.Translate(new Vector3 (0f, Input.GetAxisRaw("Vertical") * upDownSpeed * Time.deltaTime, 0f));
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, Input.GetAxisRaw("Vertical") * upDownSpeed);
            PlayerMovingVertical = true;
        }

        if(Input.GetAxisRaw("Horizontal") <0.5f && Input.GetAxisRaw("Horizontal") > -0.5)
        {
            playerRigidBody.velocity = new Vector2(0f, playerRigidBody.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5)
        {
            playerRigidBody.velocity = new Vector2( playerRigidBody.velocity.x, 0f);
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerHorizontalMoving", PlayerMovingHorizontal);
        anim.SetBool("PlayerVerticalMoving", PlayerMovingVertical);
        anim.SetFloat("LastMoveX", LastMove);

    }
}

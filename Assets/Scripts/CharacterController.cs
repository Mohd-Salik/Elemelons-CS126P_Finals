using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

	[Header("Controller Speed and Jump")]
	[Tooltip("Character Controller Speed and Jump")]
	public float speed = 2f, jumpVelocity = 10f;

	[Header("Is Player on Ground Variables")]
	public LayerMask playerMask;
	Transform playerTransform, tagGround;
	public bool isGrounded = false;

	[Header("Elemental Counters")]
	public static int airPower = 0;
	public static int waterPower = 0;
	public static int firePower = 0;
	public static int earthPower = 0;

	public static int airSeed = 4;
	public static int waterSeed = 4;
	public static int fireSeed = 4;
	public static int earthSeed = 4;

	[Header("Type and Character Switch")]
	public static int selectedType = 0;
	public static bool warriorSwap = false;
	Rigidbody2D playerRigidBody;
	bool flipped = false;

	//Initialize Basic Variables
	void Awake()
	{
		playerRigidBody = GetComponent<Rigidbody2D>();
		playerTransform = this.transform;
		tagGround = GameObject.Find(this.name+"/feet").transform;
	}


	//Linecast, identify if player is touching the ground.
	void Update(){
		isGrounded = Physics2D.Linecast(playerTransform.position, tagGround.position, playerMask);
		Move(Input.GetAxisRaw("Horizontal"));
		if (Input.GetButtonDown("Jump")){
			Jump();
		}
	
		//character switching
		if (Input.GetKeyDown("f")){
			Invoke("CharacterSwap", 0.5f);
		}

		if (Input.GetKeyDown(KeyCode.Alpha1)){
			Debug.Log("Earth Selected");
			selectedType = 1;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2)){
			Debug.Log("Water Selected");
			selectedType = 2;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3)){
			Debug.Log("Wind Selected");
			selectedType = 3;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha4)){
			Debug.Log("Fire Selected");
			selectedType = 4;
		}

		FlipPlayer();
	}

	public void CharacterSwap(){
		if (warriorSwap == false){
			warriorSwap = true;
		}
		else{
			warriorSwap = false;
		}
	}

	//Move Function, else statement locks player airborne controls.
	public void Move(float horizontalInput){
		if (isGrounded == true){
			Vector2 moveVel = playerRigidBody.velocity;
			moveVel.x = (horizontalInput * speed);
			playerRigidBody.velocity = moveVel;
		}else{
			Vector2 moveVel = playerRigidBody.velocity;
			moveVel.x = (horizontalInput * 0);
			playerRigidBody.velocity = moveVel;
		}
	}

	//Jump Function
	public void Jump(){
		if(isGrounded){
			playerRigidBody.velocity += jumpVelocity * Vector2.up;
			CharacterPlantMechanic.jumpCounter ++;
		}
	}

	//Flips the whole game object from left to right.
	public void FlipPlayer(){
		if(playerRigidBody.velocity.x < 0f){
			if (flipped != true){
				playerTransform.localScale = new Vector3(-1f, 1f, 1f);
			}
		}else if(playerRigidBody.velocity.x > 0f){
			flipped = false;
			playerTransform.localScale = new Vector3(1f, 1f, 1f);
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

	[Header("Controller Speed and Jump")]
	[Tooltip("Character Controller Speed and Jump")]
	public float speed = 3f, jumpVelocity = 10f;

	[Header("Is Player on Ground Variables")]
	public LayerMask playerMask;
	Transform playerTransform, tagGround;
	public bool isGrounded = false;

	[Header("Elemental Counters")]
	public static int airPower = 0;
	public static int waterPower = 0;
	public static int firePower = 0;
	public static int earthPower = 0;

	public static int airSeed = 0;
	public static int waterSeed = 0;
	public static int fireSeed = 0;
	public static int earthSeed = 0;
	public static int kills = 0;
	public static int harvests = 0;

	[Header("Type and Character Switch")]
	public static int selectedType = 0;
	public static int level = 1;
	public static bool warriorSwap = false;
	Rigidbody2D playerRigidBody;
	Vector3 spawnPosition;
	bool dead;

	public static bool warriorFaceRight= false;
	public static bool flipped = false;
	

	//Initialize Basic Variables
	void Awake()
	{
		playerRigidBody = GetComponent<Rigidbody2D>();
		playerTransform = this.transform;
		spawnPosition = playerTransform.position;
		tagGround = GameObject.Find(this.name+"/feet").transform;
	}


	//Linecast, identify if player is touching the ground.
	void Update(){
		if (death.respawn == true){
			Die();
		}

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
			Debug.Log("Air Selected");
			selectedType = 1;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2)){
			Debug.Log("Water Selected");
			selectedType = 2;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3)){
			Debug.Log("Earth Selected");
			selectedType = 3;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha4)){
			Debug.Log("Fire Selected");
			selectedType = 4;
		}
		else if (Input.GetKeyDown("e")){
			Debug.Log("Nothing Selected");
			selectedType = 0;
		}

		FlipPlayer();
	}

	public void Die(){
		if (!dead){
			dead = true;
			Invoke("Respawn", 5f);
			playerTransform.position = spawnPosition;
		}
	}

	public void Respawn(){
		dead = false;
		airPower = 0;
		waterPower = 0;
		firePower = 0;
		earthPower = 0;
		airSeed = 0;
		waterSeed = 0;
		fireSeed = 0;
		earthSeed = 0;
		kills = 0;
		harvests = 0;
		selectedType = 0;
		level = 1;
		warriorSwap = false;
		warriorFaceRight= false;
		flipped = false;
		death.respawn = false;
		Environment.nightTime = false;
    	Environment.dawnRise = false;
		Environment.nightTime = false;
		Environment.timer = 20f;
		Environment.dawnRise = false;
        Environment.currentTransparency = 1f;
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
				warriorFaceRight = false;
				playerTransform.localScale = new Vector3(-1f, 1f, 1f);
			}
		}else if(playerRigidBody.velocity.x > 0f){
			flipped = false;
			warriorFaceRight = true;
			playerTransform.localScale = new Vector3(1f, 1f, 1f);
		}
	}
}
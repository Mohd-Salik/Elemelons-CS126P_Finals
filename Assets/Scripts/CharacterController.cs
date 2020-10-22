using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
  public float speed = 10f, jumpVelocity = 10f;
  public LayerMask playerMask;
  Transform myTrans, tagGround;
  Rigidbody2D myBody;
  SpriteRenderer myModel;

  public bool isGrounded = false;

  void Awake(){
	myBody = this.GetComponent<Rigidbody2D>();
	myModel = this.GetComponent<SpriteRenderer>();
	myTrans = this.transform;
	tagGround = GameObject.Find(this.name+"/feet").transform;
  }

  void Update(){
	isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);
	Move(Input.GetAxisRaw("Horizontal"));
	if (Input.GetButtonDown("Jump")){
		Jump();
	}
	FlipPlayer();
  }

  public void Move(float horizontalInput){
	if (isGrounded == true){
		Vector2 moveVel = myBody.velocity;
		moveVel.x = (horizontalInput * speed);
		myBody.velocity = moveVel;
	}else{
		Vector2 moveVel = myBody.velocity;
		moveVel.x = (horizontalInput * 0);
		myBody.velocity = moveVel;
	}
  }

  public void Jump(){
	if(isGrounded){
		myBody.velocity += jumpVelocity * Vector2.up;
	}
  }

  public void FlipPlayer(){
	if(myBody.velocity.x < -0.1f){
		myModel.flipX = false;
	}else if(myBody.velocity.x > 0.1f){
		myModel.flipX = true;
	}
  }
}
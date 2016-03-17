using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WolfBehavior : MonoBehaviour {

	public float speed;
	public float jumpSpeed;
	public float health;
	public float descel;
	public GameObject finishLine;
	private Rigidbody rb2d;
	private bool isFalling = false;
	


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		if (Input.GetKey(KeyCode.Space) && !isFalling){
			rb2d.AddForce(Vector3.up * jumpSpeed);
			isFalling = true;
		}
						
		if (Input.GetKey (KeyCode.RightArrow)) {
				rb2d.AddForce(speed, 0, 0);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
				rb2d.AddForce(-speed, 0, 0);
		} else {	
			if (rb2d.velocity.x > 0) {
					rb2d.AddForce (-descel, rb2d.velocity.y, 0);
			} else if (rb2d.velocity.x < 0) {
					rb2d.AddForce (descel, rb2d.velocity.y, 0);
			} else {
					rb2d.velocity = new Vector3 (0, rb2d.velocity.y, 0);
			}
		}

		if (transform.position.y < 800) {
			SceneManager.LoadScene ("test");
		}
			
	
	}


	void OnCollisionEnter (Collision collision){
		isFalling = false;
		
	}

	public void HurtWolf (float decreaseBy){
		health -= decreaseBy;
			
	}
	
	void CheckIfWolfIsDead (){
		if (health == 0) {
			GoToLevel1 ();
		}		
	}

	void GoToLevel1 (){
		//Application.LoadScene ("test");
	}
}

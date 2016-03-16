using UnityEngine;
using System.Collections;

public class WolfBehavior : MonoBehaviour {

	public float speed;
	public float jumpSpeed;
	private Rigidbody rb2d;
	private bool isFalling = false;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb2d.velocity = new Vector3 (0, rb2d.velocity.y, 0);
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//				Vector2 movement = new Vector2 (moveHorizontal, 0);

//		rb2d.AddForce (movement * speed);
		if (Input.GetKey(KeyCode.Space) && !isFalling){
			rb2d.AddForce(Vector3.up * jumpSpeed);
			isFalling = true;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rb2d.velocity = new Vector3 (speed, rb2d.velocity.y, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
						rb2d.velocity = new Vector3 (-speed, rb2d.velocity.y, 0);
		}
			
	
	}

	void OnCollisionStay(){
		isFalling = false;			
	}
}

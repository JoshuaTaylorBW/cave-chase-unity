using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public GameObject wolf; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//On wolf collision, call hurt wolf
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "wolf") {
		// probably going to need to change the gameobject.name
			wolf.GetComponent<WolfBehavior> ().HurtWolf (1);
		}
	}
}

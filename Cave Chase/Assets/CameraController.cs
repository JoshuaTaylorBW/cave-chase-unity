using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

		public GameObject player;

		private Vector3 offset;

		// Use this for initialization
		void Start () {

				offset = transform.position - player.transform.position;

		}

		// Use LateUpdate for procedurals, animations, and other things, to validate that all the other updates have occurred before updating.
		void LateUpdate () {


				transform.position = new Vector3(GameObject.Find ("wolf").transform.position.x + offset.x, transform.position.y, transform.position.z);

		}
}
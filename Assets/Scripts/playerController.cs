using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed;
	public float jump_power;

	private Rigidbody2D rb;
	private bool jumping = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position = new Vector3 (transform.position.x - speed, transform.position.y, transform.position.z);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
		}

		if (Input.GetKey (KeyCode.Space)) {
			rb.AddForce (new Vector2 (0, jump_power));
			jumping = true;
		}
	}
}

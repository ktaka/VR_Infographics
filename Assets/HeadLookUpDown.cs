using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookUpDown : MonoBehaviour {
	public float velocity = 0.7f;
	public float maxHeight = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float moveY = Camera.main.transform.forward.y * velocity * Time.deltaTime;
		float newY = transform.position.y + moveY;
		if (newY >= 0f && newY < maxHeight) {
			transform.position = new Vector3 (transform.position.x, newY, transform.position.z);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpToAnotherSpace : MonoBehaviour {
	public float timeToSelect = 3.0f;
	public GameObject warpTo;
	public GameObject cameraObject;
	public GameObject warpEffect;
	private float countDown;
	private Renderer rendererObj;

	// Use this for initialization
	void Start () {
		countDown = timeToSelect;
		rendererObj = GetComponent<Renderer> ();
	}

	void Reset () {
		countDown = timeToSelect;
		rendererObj.material.SetColor ("_Color", Color.white);
	}

	// Update is called once per frame
	void Update () {
		Transform camera = Camera.main.transform;
		Ray ray = new Ray (camera.position, Camera.main.transform.forward);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit) && (hit.collider.gameObject == gameObject)) {
			if (countDown > 0.0f) {
				countDown -= Time.deltaTime;
				rendererObj.material.SetColor ("_Color", Color.red);
			} else {
				cameraObject.transform.position = warpTo.transform.position;
				Vector3 effectPos = warpTo.transform.position;
				effectPos += (camera.transform.forward * 0.3f);
				GameObject warpEffectObj = Instantiate (warpEffect, effectPos, warpTo.transform.rotation);
				Destroy (warpEffectObj, 2.0f);
				Reset ();
			}
		} else {
			Reset ();
		}
	}
}

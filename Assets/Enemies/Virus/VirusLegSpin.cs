﻿using UnityEngine;
using System.Collections;

public class VirusLegSpin : MonoBehaviour {
	public GameObject legs;
	Vector3 rotationAmount = new Vector3(0,180f,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		legs.transform.Rotate (rotationAmount * Time.smoothDeltaTime);
	}
}

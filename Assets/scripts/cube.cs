﻿using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float tt = Time.deltaTime;
		transform.Rotate(tt*2.1f,tt*3.1f,tt*3.3f);
	}
}

using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float tt = Time.deltaTime;
		transform.Rotate(tt*20.0f,tt*35.0f,tt*33.0f);
	}
}

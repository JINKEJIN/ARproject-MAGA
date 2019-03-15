using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeControl : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeSize(){

		transform.localScale += new Vector3(0.01F, 0.01F, 0.01F);

	}
}

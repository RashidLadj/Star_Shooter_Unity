﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float deplacementHorizontal = Input.GetAxis("Horizontal");
		float deplacementVertical = Input.GetAxis("Vertical");
		Vector3 mouvement = new Vector3(deplacementHorizontal, 0, deplacementVertical);
		GetComponent<Rigidbody>().velocity = mouvement;	


	}	
}

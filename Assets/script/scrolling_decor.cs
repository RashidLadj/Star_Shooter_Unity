﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling_decor : MonoBehaviour {

	public float vitesseDefilement;
	Renderer rend;
	// Use this for initialization
	void Start () {
		rend = gameObject.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * vitesseDefilement;
		rend.material.mainTextureOffset = new Vector2(0, offset);
		
	}
}

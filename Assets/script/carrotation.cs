﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotation : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		transform.Rotate(new Vector3(0,20,0) *Time.deltaTime);
	}
}

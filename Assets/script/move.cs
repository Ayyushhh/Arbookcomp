using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public float xvalue,yvalue,zvalue;
	
	void Start () {
		
	}
	
	
	void Update () {
		 transform.Translate(new Vector3(xvalue,yvalue ,zvalue) *Time.deltaTime);
	}
}

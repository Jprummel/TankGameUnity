using UnityEngine;
using System.Collections;

public class MoveTank : MonoBehaviour {
	public float rotationSpeed = 8.5f;
	public float moveSpeed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			//(0,0,1); gaat dus 1 unit vooruit op de Z as
			transform.Translate(Vector3.forward * moveSpeed);
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate(-Vector3.forward * moveSpeed);		
		} 

		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Rotate(-Vector3.up * rotationSpeed);		
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			transform.Rotate(Vector3.up * rotationSpeed);		
		} 
	}
}

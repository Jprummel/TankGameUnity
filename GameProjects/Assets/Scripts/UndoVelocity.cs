using UnityEngine;
using System.Collections;

public class UndoVelocity : MonoBehaviour {
	Rigidbody rigid;

	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(rigid.velocity != Vector3.zero)//(zero = 0,0,0)
		{
			rigid.velocity = Vector3.zero;
		}
		if (rigid.angularVelocity != Vector3.zero) 
		{
			rigid.angularVelocity = Vector3.zero;
		}
	}
}

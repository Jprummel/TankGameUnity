using UnityEngine;
using System.Collections;

public class EnemyShoots : MonoBehaviour {
	private float reloadTime;
	public float timeToReload;
	public GameObject bulletPrefab;
	public float shoottingRange;
	private Transform nozzle;
	private Transform turret;
	// Use this for initialization
	void Start () {
		reloadTime = 0f;

		Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform>();
		foreach (Transform t in transforms) 
		{
			if(t.gameObject.name == "turret")
			{

				turret = t;
			}
			if(t.gameObject.name == "nozzle")
			{
				nozzle = t;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		reloadTime += Time.deltaTime;
		if (reloadTime >= timeToReload) 
		{
			CheckForPlayer();
		}
	}
	private void CheckForPlayer()
	{
		Ray myRay = new Ray ();
		myRay.origin = turret.position;
		myRay.direction = turret.forward;
		
		RaycastHit hitInfo;
		//Checken met behulp van raycast of de player in zicht is
		if(Physics.Raycast(myRay, out hitInfo, 10f))
		{
			print("hitInfo.collider.gameObject.name");
			string targetName = hitInfo.collider.gameObject.name;

			if(targetName == "Tank")
			{
				Instantiate(bulletPrefab, nozzle.position, nozzle.rotation);

				reloadTime = 0f;
			}
		
		}

		//zo ja schieten en reload time weer op 0 zetten
	}
}

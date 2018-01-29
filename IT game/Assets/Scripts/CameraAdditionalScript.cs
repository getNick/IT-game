using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAdditionalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

			if (hit.collider != null)
			{
				var obj = hit.collider.gameObject.GetComponent("Ballon")as Ballon ;
				if(obj!=null){
					obj.Explore();
					Destroy(hit.collider.gameObject);
				}
			}
		}
	}
}

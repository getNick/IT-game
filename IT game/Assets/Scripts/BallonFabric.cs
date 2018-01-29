using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonFabric : MonoBehaviour {
	public GameObject objectPrefab;
	private float speed = 1.0f;

	void Start()
	{
		StartCoroutine(SpawnObjects());
	}


	IEnumerator SpawnObjects()
	{
		Vector3 position;

		while (true)
		{
			position = new Vector3(Random.Range(-2.5f, 2.5f), -6.0f, 0.0f);
			Instantiate(objectPrefab, position, Quaternion.identity);
			if (speed > 0.1)
			{
				speed -= 0.01f;
			}
			yield return new WaitForSeconds(speed);
		}
	}
}

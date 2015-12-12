using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour 
{
	public GameObject myPrefab;
	public float timer = 0f;
	public float fireTime = 15f;
	public int counter;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer = timer + Time.deltaTime;
		if (timer >= fireTime) 
		{
			Instantiate(myPrefab, gameObject.transform.position, gameObject.transform.rotation);
			timer = 0f;
		}
	}
}

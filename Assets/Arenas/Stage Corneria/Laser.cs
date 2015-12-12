using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour 
{
	public float speed;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Vector3.up * speed * Time.deltaTime);
	}
}

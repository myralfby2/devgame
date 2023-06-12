using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 0.1f;

	private void Update() 
	{
		transform.position += new Vector3(speed, 0, 0) * Input.GetAxis("Horizontal");
		transform.position += new Vector3(0, speed, 0) * Input.GetAxis("Vertical");

		if(Input.GetAxis("Horizontal") < 0)
		{
			GetComponent<SpriteRenderer>().flipX = true;
		}

		if(Input.GetAxis("Horizontal") > 0)
		{
			GetComponent<SpriteRenderer>().flipX = false;
		}
	}
}
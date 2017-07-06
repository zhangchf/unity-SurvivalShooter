using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


	public Transform target;
	public float smooth = 5f;

	Vector3 offset;

	void Start ()
	{
		offset = transform.position - target.position;
	}

	void FixedUpdate ()
	{
		Vector3 newCamPos = offset + target.position;
		transform.position = Vector3.Lerp (transform.position, newCamPos, smooth * Time.deltaTime);
	}
}

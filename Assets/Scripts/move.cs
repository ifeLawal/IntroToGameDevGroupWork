using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float moveSpeed = 0.1f;
	public float turnSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey( KeyCode.UpArrow ) ) {
			transform.position += transform.forward * moveSpeed;
		}
		if ( Input.GetKey( KeyCode.LeftArrow ) ) {
			transform.position = transform.position + new Vector3( -moveSpeed, 0f, 0f);
		}
		if ( Input.GetKey( KeyCode.RightArrow ) ) {
			transform.position = transform.position + new Vector3( moveSpeed, 0f, 0f);
		}
		if ( Input.GetKey( KeyCode.DownArrow ) ) {
			transform.position += -transform.forward * moveSpeed;
		}
		if ( Input.GetKey( KeyCode.A ) ) {
			transform.position += transform.up * moveSpeed;
		}
		if ( Input.GetKey( KeyCode.D ) ) {
			transform.position += -transform.up * moveSpeed;
		}
	}
}

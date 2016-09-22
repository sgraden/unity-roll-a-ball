using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate will only update once all other updates have been set
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}

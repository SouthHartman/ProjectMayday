using UnityEngine;
using System.Collections;

public class PlayerSendDoor : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	void Update() {
		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(transform.position, fwd, out hit, 5f)) {
			if (hit.collider.CompareTag ("Door")) {
				hit.transform.SendMessage ("Open", SendMessageOptions.DontRequireReceiver);
			} else if (hit.collider.CompareTag ("RoomDoor") && hit.distance < 2f && Input.GetButtonDown ("Fire1")) {
				print ("room door");
				hit.transform.SendMessage ("Open", SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}

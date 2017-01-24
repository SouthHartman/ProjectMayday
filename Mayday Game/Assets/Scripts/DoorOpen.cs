using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {
	private Animator anim;
	private bool interact = true;
	private float counter = 0.0f;
	public float doorCloseTime = 6f;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!interact) {
			counter += Time.deltaTime;

			if (counter > doorCloseTime) {
				anim.SetTrigger ("Close");
				counter = 0;
				interact = true;
			}

		}
	}

	void Open () {
		if (interact) {
			anim.SetTrigger ("Open");
			interact = false;
		}
	}
}

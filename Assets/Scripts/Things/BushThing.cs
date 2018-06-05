using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushThing : ThingIn {
	public GameObject fireReplacement;

	int fireCount = 0;
	bool burningDown = false;

	void FixedUpdate () {
		if (fireCount > 0) {
			fireCount -= 1;
		}

		if (!burningDown && fireCount > 30) {
			Instantiate (fireReplacement, transform.position, transform.rotation);
			burningDown = true;
		}

		if (fireCount > 600) {
			Destroy (gameObject);
		}
	}

	public override void OnThing (ThingTag tag) {
		switch (tag) {
			case ThingTag.Flame:
				fireCount += 2;
				return;
		}
	}
}
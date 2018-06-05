using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ThingIn : MonoBehaviour {

	public abstract void OnThing (ThingTag tag);

	void OnTriggerStay (Collider other) {
		ThingOut emittingThing = other.gameObject.GetComponent<ThingOut> ();
		if (emittingThing == null) {
			return;
		}

		ThingTag[] otherTags = emittingThing.thingTags;
		foreach (ThingTag tag in otherTags) {
			OnThing (tag);
		}
	}
}
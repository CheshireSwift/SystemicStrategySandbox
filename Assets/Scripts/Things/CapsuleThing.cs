using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleThing : ThingIn {
	public override void OnThing (ThingTag tag) {
		switch (tag) {
			case ThingTag.Flame:
				// Debug.Log ("AAAAAH FIRE");
				return;
			case ThingTag.box:
				// Debug.Log ("omgbox");
				return;
		}
	}
}
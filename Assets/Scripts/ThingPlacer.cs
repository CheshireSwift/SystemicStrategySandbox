using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlaceableThing {
	public GameObject thing;
	public Texture2D icon;
}

public class ThingPlacer : MonoBehaviour {
	public PlaceableThing[] things;
	public uint thingIndex = 0;

	PlaceableThing selectedThing {
		get {
			return things[thingIndex];
		}
	}

	// Use this for initialization
	void Start () {
		UpdateCursor ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit, Mathf.Infinity, ~(1 << 8))) {
				Instantiate (selectedThing.thing, hit.point, new Quaternion ());
			} else {
				Debug.Log ("missed");
			}
		}

		if (Input.GetKeyDown ("1")) {
			thingIndex = 0;
			UpdateCursor ();
		}

		if (Input.GetKeyDown ("2")) {
			thingIndex = 1;
			UpdateCursor ();
		}

		if (Input.GetKeyDown ("3")) {
			thingIndex = 2;
			UpdateCursor ();
		}
	}

	private void UpdateCursor () {
		Cursor.SetCursor (selectedThing.icon, new Vector2 (64, 64), CursorMode.Auto);
	}
}
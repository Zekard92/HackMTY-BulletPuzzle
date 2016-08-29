using UnityEngine;
using System.Collections;

public class Targets : MonoBehaviour {

	public GameObject door;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDestroy()
	{
		//door.GetComponent<OpenDoor> ().hit ();
		Debug.Log ("Destroyed");
	}
}

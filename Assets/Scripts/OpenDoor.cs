using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	public int numTarget;
	public int hitted;
	public GameObject door;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hitted >= numTarget) {
			door.transform.Translate (Vector3.up * 5 * Time.deltaTime);
			Destroy (door);
		}
	}

	public void hit()
	{
		hitted++;
		Debug.Log ("Hitted");
	}
}

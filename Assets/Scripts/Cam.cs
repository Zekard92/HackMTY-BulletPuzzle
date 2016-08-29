using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {

	public GameObject parent;
	public int speed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles += new Vector3 (-Input.GetAxis ("Mouse Y"), 0);
	}
}

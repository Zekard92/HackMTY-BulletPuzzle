using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public int speed;
	public int rotSpeed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Cursor.visible)
			Cursor.visible = false;
		transform.Translate (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis ("Vertical") * speed * Time.deltaTime);
		transform.eulerAngles += new Vector3 (0, Input.GetAxis ("Mouse X") * rotSpeed, 0);
	}
}

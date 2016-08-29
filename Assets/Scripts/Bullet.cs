using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public GameObject gObject;
	public short bounces;
	private float init;
	// Use this for initialization
	void Start () {
		bounces = 0;
		init = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward/2);
		if(Time.realtimeSinceStartup-init>=5)
			Destroy (gObject);
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Target") {
			col.gameObject.GetComponent<Targets> ().door.GetComponent<OpenDoor> ().hit ();
			Debug.Log ("Bullet");
			Destroy (col.gameObject);
			Destroy (gObject);
		}
		if(bounces++ >= 1)
			Destroy (gObject);
	}
}
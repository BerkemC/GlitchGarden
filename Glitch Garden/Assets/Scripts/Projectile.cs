using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float speed,damage;
	// Use this for initialization
	void Start () {
		if (gameObject.tag == "Corgette")
			damage = 100f;
		else if (gameObject.tag == "Axe")
			damage = 150f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * speed * Time.deltaTime);

	}

}

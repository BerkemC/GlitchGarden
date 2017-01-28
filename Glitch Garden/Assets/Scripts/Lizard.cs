using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Attack))]
public class Lizard : MonoBehaviour {
	private Attack attack;
	// Use this for initialization
	void Start () {
		attack = GetComponent<Attack> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		GameObject obj = col.gameObject;
		if (!obj.GetComponent<Defender> ())
			return;
		else {
			GetComponent<Animator> ().SetBool ("IsAttacking", true);
			attack.AttackEnemy (obj);
		}
	}

}

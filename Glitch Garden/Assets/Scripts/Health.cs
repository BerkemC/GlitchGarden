using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float health;
	// Use this for initialization
	void Start () {
		SetTheHealth ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetTheHealth(){
		if (GetComponent<Fox> ())
			health = 150f;
		else if (GetComponent<Lizard> ())
			health = 200f;
		else if (GetComponent<Stone> ())
			health = 800f;
		else if (GetComponent<StarTrophy> ())
			health = 400f;
		else if (GetComponent<Gnome> ())
			health = 500f;
		else if (GetComponent<Cactus> ())
			health = 500f;
	}
	void OnTriggerEnter2D(Collider2D col){
		float damageTaken;
		if (col.gameObject.GetComponent<Projectile> ()) {
			damageTaken = col.gameObject.GetComponent<Projectile> ().damage;
			health -= damageTaken;
			Destroy (col.gameObject);
			if (health < 0)
				Destroy (gameObject);
		}

		
	}
	public void dealDamage ( float damage){
		health -= damage;
		if (health < 0)
			Destroy (gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	public float SeenFrequency;
	private float walkSpeed;
	private GameObject currentEnemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkSpeed * Time.deltaTime);
		if (!currentEnemy)
			GetComponent<Animator> ().SetBool ("IsAttacking", false);
	}

	public void  changeWalkSpeed(float newSpeed){
		walkSpeed = newSpeed;
	}
	public void strike(float damage){
		if(currentEnemy) {
			Health hp = currentEnemy.GetComponent<Health> ();
			if(hp){
				hp.dealDamage (damage);
			}
		}
	}
	public void AttackEnemy(GameObject obj){
		currentEnemy = obj ;
	}
}

using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject projectile;
	private GameObject projectileParent;
	void Start(){
		projectileParent = GameObject.Find ("Projectiles");

		if (!projectileParent)
			projectileParent = new GameObject ("Projectiles");
	}
	void Update(){
		if(isAttacker ()){
			GetComponent <Animator>().SetBool("IsAttacking",true);
		}else{
			GetComponent <Animator>().SetBool("IsAttacking",false);
		}
	}
	private void Fire(){
		GameObject newProjectile = Instantiate (projectile,new Vector3(transform.FindChild("Gun").transform.position.x,transform.FindChild("Gun").transform.position.y,0f),Quaternion.identity) as GameObject;
		newProjectile.transform.parent = projectileParent.transform;
	}
	bool isAttacker(){
		foreach(Transform child in GameObject.Find("Spawners").transform){
			if(child.transform.position.y == transform.position.y) {
				foreach (Transform newChild in child.transform) {
					if (newChild) {
						if (newChild.transform.position.y == transform.position.y && newChild.transform.position.x < 10f)
							return true;
					}
				}
			}
		}
		return false;
	}
}

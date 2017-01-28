using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {
	
	void OnTriggerStay2D(Collider2D col){
		if(col.GetComponent <Attack>())GetComponent <Animator>().SetTrigger ("isAttacked");
	}
}

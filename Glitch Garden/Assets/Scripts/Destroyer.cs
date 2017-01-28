using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Destroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if(gameObject.tag == "Destroyer") Destroy (col.gameObject);
		if(gameObject.tag == "LooseCollider"){
			GameObject.FindObjectOfType <Base>().Health -= 10;
			Destroy (col.gameObject);
		}
	}
}

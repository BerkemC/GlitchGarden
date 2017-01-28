using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject[] EnemyList;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject enemy in EnemyList){
			if(isTime(enemy)){
				SpawnEnemy (enemy);
			}
		}
	}

	void SpawnEnemy(GameObject enemy){
		GameObject newEnemy = Instantiate (enemy, transform.position, Quaternion.identity) as GameObject;
		newEnemy.transform.parent = transform;
	}
	bool isTime(GameObject obj){
		if (Random.value <( obj.GetComponent <Attack> ().SeenFrequency /500*Time.deltaTime))
			return true;
		return false;
	}
}

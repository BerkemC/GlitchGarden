using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Base : MonoBehaviour {
	public int Health = 100;
	public Text HealthText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0)
			Application.LoadLevel ("Lose");
		HealthText.text = "Base Health\n" + Health.ToString ();
	}
}

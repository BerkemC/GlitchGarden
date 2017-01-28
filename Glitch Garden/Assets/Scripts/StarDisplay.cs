using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StarDisplay : MonoBehaviour {
	private Text starText;
	private int starNumber = 100;
	// Use this for initialization
	void Start () {
		starText = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		starText.text = "Star Count\n"+starNumber.ToString ();
	}

	public void AddStar(int StarNumber){
		starNumber += StarNumber;
	}

	public bool ReduceStar(int StarNumber){
		if (starNumber - StarNumber < 0)
			return false;
		starNumber -= StarNumber;
		return true;
	}
}

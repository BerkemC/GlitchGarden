using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FadeIn : MonoBehaviour {
	public float time;
	private Image FadeImage;
	private Color color = Color.black;

	// Use this for initialization
	void Start () {
		FadeImage = GetComponent <Image> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(Time.timeSinceLevelLoad < time){
			float alphaChange = Time.deltaTime / time;
			color.a -= alphaChange;
			FadeImage.color = color;	
		}else{
			gameObject.SetActive (false) ;
		}
	}
}

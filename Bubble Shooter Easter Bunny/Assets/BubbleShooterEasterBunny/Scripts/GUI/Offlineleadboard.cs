using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Offlineleadboard : MonoBehaviour {
    TMP_Text label;
	// Use this for initialization
	void OnEnable () {
        label = transform.Find( "Slot" ).Find( "Score" ).GetComponent<TMP_Text>();
        label.text = "" +  PlayerPrefs.GetInt( "Score" + PlayerPrefs.GetInt( "OpenLevel"));
	}
	
	// Update is called once per frame
	void OnDisable () {
        label.text = "";
	}
}

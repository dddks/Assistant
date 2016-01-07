using UnityEngine;
using System;
using System.Collections;
using System.Globalization;

public class Today : MonoBehaviour {

	UILabel daylabel;
	public DateTime today;
	public string text;

	// Use this for initialization
	void Start () {
		daylabel = this.GetComponent<UILabel> ();
		today = DateTime.Today;
		text = today.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
		daylabel.text = text;


	}
}

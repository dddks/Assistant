using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public int setcount = 0;
	public static Manager instance = null;


	void Awake()
	{
		instance = this;
	}

	public void SetCount()
	{
		setcount++;
		Debug.Log (setcount.ToString ());
	}
}

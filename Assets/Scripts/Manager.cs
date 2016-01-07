using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	
	public static Manager instance = null;


	void Awake()
	{
		instance = this;
	}


}

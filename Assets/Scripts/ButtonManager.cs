using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

	public void OnClickCountBtn()
	{
		Application.LoadLevel ("Assistant_count");
	}

	public void OnClickMonthBtn()
	{
		Application.LoadLevel ("Assistant_Month");
	}

	public void OnClickSettingBtn()
	{
		Application.LoadLevel ("Assistant_setting");
	}


	public void OnClickExitBtn()
	{
		Application.Quit();
	}
}

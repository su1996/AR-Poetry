using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextChange : MonoBehaviour {

	public TextAsset ShiRenJianJie;
	public Text text1;

	bool foundTarget =false;
	// Use this for initialization
	void Start () 
	{
		Vuforia.MyTrackableEvent.textAppear = FoundTarget;
		Vuforia.MyTrackableEvent.textLost = NotFoundTarget;

		text1.text = ShiRenJianJie.text;
		text1.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 worldPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition); //世界坐标转成屏幕坐标
		if(Input.GetMouseButton(0)==true)
		{
			ButtonDown ();
		}

		if(foundTarget == true)
		{
			text1.transform.position +=new Vector3 (0,10f*Time.deltaTime,0);
		}
	
	}

	void FoundTarget ()
	{
		text1.enabled = true;
		foundTarget = true;
	}
	void NotFoundTarget ()
	{
		foundTarget = false;
	}

	void ButtonDown()
	{
		if (foundTarget == false) {
			foundTarget = true;
		} else {
			foundTarget = false;
		}
	}
}

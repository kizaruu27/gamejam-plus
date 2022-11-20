using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseHover : MonoBehaviour
{
    public SceneController scenes;
	
    void OnMouseOver()
	{
		scenes.CheckClickToNext = false;
		Debug.Log("Mouse over object!");
	}
	
	void OnMouseExit()
	{
		scenes.CheckClickToNext = true;
		Debug.Log("Mouse leaves object!");
	}
}

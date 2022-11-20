using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseHover : MonoBehaviour
{
    public SceneController scenes;
	
    void OnMouseOver()
	{
		scenes.CheckClickToNext = false;
	}
	
	void OnMouseExit()
	{
		scenes.CheckClickToNext = true;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public StoryScene currentScene;
	public TextboxStory_Controller textbox;
	public bool CheckClickToNext;
	public bool isAutoPlay;
	
	public GameObject buttonNext;
	public Sprite buttonNextNormal;
	public Sprite buttonNextAuto;
	
    void Start()
    {
        textbox.PlayScene(currentScene);
		CheckClickToNext = true;
    }

    
    void Update()
    {
        MouseControl();
		AutoPlay();
    }
	
	void MouseControl()
	{
		if(CheckClickToNext){
			if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
			{
				if(textbox.IsCompleted())
				{
					textbox.PlayNextSentences();
				}
				else{
					textbox.InstantSkip = true;
				}
			}
		}
	}
	
	public void PreviousSentences()
	{
		if(textbox.IsCompleted())
		{
			textbox.PlayPreviousSentences();
		}
	}
	
	public void RepeatText()
	{
		if(textbox.IsCompleted())
		{
			textbox.RepeatSentences();
		}
	}
	
	public void EnableStoryClickMouse()
	{
		CheckClickToNext = true;
	}
	public void DisableStoryClickMouse()
	{
		CheckClickToNext = false;
	}
	
	public void EnableAutoPlay()
	{
		isAutoPlay = !isAutoPlay;
		if(isAutoPlay){
			buttonNext.GetComponent<Image>().sprite = buttonNextAuto;
			Debug.Log("Sudah");
		}
		else{
			buttonNext.GetComponent<Image>().sprite = buttonNextNormal;
		}
	}
	
	public void AutoPlay()
	{
		if(isAutoPlay){
			if(textbox.IsCompleted())
			{
				StartCoroutine(Wait1S());
			}
		}
	}
	IEnumerator Wait1S()
	{
		yield return new WaitForSeconds(3);
		textbox.PlayNextSentences();
	}
}

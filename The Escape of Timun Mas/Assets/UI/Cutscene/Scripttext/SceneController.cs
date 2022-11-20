using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public StoryScene currentScene;
	public TextboxStory_Controller textbox;
	public bool CheckClickToNext;
	
    void Start()
    {
        textbox.PlayScene(currentScene);
		CheckClickToNext = true;
    }

    
    void Update()
    {
        MouseControl();
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
		textbox.PlayPreviousSentences();
	}
}
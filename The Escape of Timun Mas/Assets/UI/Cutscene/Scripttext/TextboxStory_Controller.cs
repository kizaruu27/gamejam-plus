using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextboxStory_Controller : MonoBehaviour
{
	public TextMeshProUGUI barText;
	public TextMeshProUGUI personNameText;
	
	public float waitForText = 0.05f;
	
	private int sentenceIndex;
	private StoryScene currentScene;
	private State state = State.COMPLETED;
	
	private enum State
	{
		PLAYING, COMPLETED
	}
	
	public void PlayScene(StoryScene scene)
	{
		currentScene = scene;
		sentenceIndex = -1;
		PlayNextSentences();
	}
	
	public bool IsCompleted()
	{
		return state == State.COMPLETED;
	}
	
    public void PlayNextSentences()
    {
		if(sentenceIndex+1 < currentScene.sentences.Count){
			StartCoroutine(TypeText(currentScene.sentences[++sentenceIndex].text));
			personNameText.text = currentScene.sentences[sentenceIndex].speaker.speakerName;
			//personNameText.color = currentScene.sentences[sentenceIndex].speaker.textColor;
			
			//Debug.Log(currentScene.sentences[sentenceIndex].speaker.speakerName);
			//Debug.Log("index= "+ sentenceIndex + "dan Current= " + currentScene.sentences.Count);
		}
    }
	
	public void PlayPreviousSentences()
	{
		Debug.Log(sentenceIndex);
		if(sentenceIndex > 0){
			StartCoroutine(TypeText(currentScene.sentences[--sentenceIndex].text));
			personNameText.text = currentScene.sentences[sentenceIndex].speaker.speakerName;
		}
	}
	
	void Update()
	{
		
	}

	public bool InstantSkip;
    private IEnumerator TypeText(string text)
	{
		barText.text = "";
		state = State.PLAYING;
		int wordIndex = 0;
		
		while (state != State.COMPLETED)
		{
			barText.text += text[wordIndex];
			yield return new WaitForSeconds(waitForText);
			
			if(++wordIndex == text.Length){
				state = State.COMPLETED;
				break;
			}
			if(InstantSkip){
				InstantSkip = !InstantSkip;
				barText.text = currentScene.sentences[sentenceIndex].text;
				state = State.COMPLETED;
				break;
			}
		}
	}
}

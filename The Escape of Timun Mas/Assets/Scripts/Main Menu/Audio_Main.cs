using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio_Main : MonoBehaviour
{
	//AudioSource bgm_main;
	public Sprite VolumeOnImage;
	public Sprite VolumeOffImage;
	public GameObject ButtonAudio;
	
	public GameObject BackgroundAudio;
	public bool BGMStatus;
	
	public GameObject SliderBGM;
	
    // Start is called before the first frame update
    void Start()
    {
		BGMStatus = true;
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void setBGMStatus(){
		if(BGMStatus){
			//Debug.Log("Audio On!");
			ButtonAudio.GetComponent<Image>().sprite = VolumeOffImage;
			BackgroundAudio.GetComponent<AudioSource>().Stop();
			SliderBGM.SetActive(false);
			BGMStatus = !BGMStatus;
		}
		else{
			//Debug.Log("Audio Off!");
			ButtonAudio.GetComponent<Image>().sprite = VolumeOnImage;
			BackgroundAudio.GetComponent<AudioSource>().Play();
			SliderBGM.SetActive(true);
			BGMStatus = !BGMStatus;
		}
	}
	
	public void setVolumeSlider(float values){
		//Debug.Log(values);
		BackgroundAudio.GetComponent<AudioSource>().volume = values;
	}
}

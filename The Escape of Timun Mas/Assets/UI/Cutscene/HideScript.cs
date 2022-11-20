using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideScript : MonoBehaviour
{
    public GameObject objek1;
	public GameObject objek2;
	public GameObject objek3;
	
	public TextboxStory_Controller textbox;
	
	bool isHidden = true;

    public void HiddenAll(){
		if(textbox.IsCompleted()){
			if(isHidden){
				isHidden = !isHidden;
				objek1.SetActive(isHidden);
				objek2.SetActive(isHidden);
				objek3.SetActive(isHidden);
			}
			else{
				isHidden = !isHidden;
				objek1.SetActive(isHidden);
				objek2.SetActive(isHidden);
				objek3.SetActive(isHidden);
			}
		}
	}
}

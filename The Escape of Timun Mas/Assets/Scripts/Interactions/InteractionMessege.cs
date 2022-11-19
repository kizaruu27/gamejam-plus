using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionMessege : MonoBehaviour
{
    public TextMeshProUGUI interactionMessege;
    public float messegeTime;
    
    public void SetInteractionMessege(string messege)
    {
        StartCoroutine(SetMessege(messege));
    }

    IEnumerator SetMessege(string messege)
    {
        interactionMessege.text = messege;
        yield return new WaitForSeconds(messegeTime);
        interactionMessege.text = null;
    }
}

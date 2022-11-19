using UnityEngine;


//script ini bakal diubah2, sekarang cuma dummy aja
public class DoorPuzzle : MonoBehaviour
{
   public GameObject doorObject;
   
   public void OpenDoor()
   {
      doorObject.SetActive(false);
   }
}

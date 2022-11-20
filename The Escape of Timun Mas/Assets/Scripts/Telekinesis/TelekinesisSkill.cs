using UnityEngine;

public class TelekinesisSkill : MonoBehaviour
{
    public string targetTag;
    public float transitionSpeed = 5;
    public GameObject interactionUI;
    public Transform targetTransform;
    public AudioSource AudioTele;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == targetTag)
        {
            interactionUI.SetActive(true);
            if (Input.GetMouseButton(0))
            {
                //AudioTele.Play();
                other.transform.position = Vector3.MoveTowards(other.transform.position, targetTransform.position, transitionSpeed * Time.deltaTime);
                other.transform.GetComponent<Rigidbody>().useGravity = false;
                other.transform.GetComponent<BoxCollider>().isTrigger = true;
            }
            else
            {
                other.transform.GetComponent<Rigidbody>().useGravity = true;
                other.transform.GetComponent<BoxCollider>().isTrigger = false;
                //AudioTele.Stop();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == targetTag)
        {
            interactionUI.SetActive(false);
            other.transform.GetComponent<Rigidbody>().useGravity = true;
            other.transform.GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}

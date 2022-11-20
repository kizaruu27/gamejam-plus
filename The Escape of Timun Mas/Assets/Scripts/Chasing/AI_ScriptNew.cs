using UnityEngine;

public class AI_ScriptNew : MonoBehaviour
{
	public GameObject ThePlayer;
	public GameObject TheEnemy;
	
	public float targetDistance;
	public float AllowedDistance = 5f;

	public float speed;
	float FollowSpeed;
	
	RaycastHit shoot;
	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
	    Vector3 rotate = ThePlayer.transform.position - transform.position;
	    Quaternion lockRotation = Quaternion.LookRotation(rotate);
	    Vector3 rotation = Quaternion.Lerp(transform.rotation, lockRotation, 10 * Time.deltaTime).eulerAngles;
	    transform.localRotation = Quaternion.Euler(0, rotation.y, 0);
	    
        // transform.LookAt(ThePlayer.transform);
		if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shoot)){
			targetDistance = shoot.distance;
			if(targetDistance >= AllowedDistance)
			{
				FollowSpeed = speed;
				//TheEnemy.GetComponent<animation>
				transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed * Time.deltaTime);
			}
			else
			{
				FollowSpeed = 0;
				//TheEnemy.GetComponent<animation>
			}
		}
    }
}

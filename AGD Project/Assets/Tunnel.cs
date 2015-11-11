using UnityEngine;
using System.Collections;

public class Tunnel : MonoBehaviour {

	private float tunnelTime = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			other.GetComponent<MeshRenderer>().enabled = false;
			startCoroutine(TunnelTravel(GameObject other.gameObject));
		}
	}

	IEnumerator TunnelTravel(GameObject traveller)
	{
		tunnelTime += 1.0f * Time.deltaTime;

		if (tunnelTime > 3) 
		{
			string tunnelName = GameObject.Find("Tunnel Entrance" + Random.range(1, 5).ToString());
			if (tunnelName == this.gameObject.name)
			{

			}
			traveller.transform = 
			traveller.GetComponent<MeshRenderer>().enabled = true;
		}
	}
}

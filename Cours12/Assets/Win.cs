using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
    public AudioClip laugh;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider collider)
    {
        FindObjectOfType<MusicPlayer>().GetComponent<AudioSource>().PlayOneShot(laugh);
    }
}

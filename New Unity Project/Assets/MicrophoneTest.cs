using UnityEngine;
using System.Collections;

public class MicrophoneTest : MonoBehaviour {

	void Start() {
		AudioSource aud = GetComponent<AudioSource>();
		aud.clip = Microphone.Start("Built-in Microphone", true, 10, 44100);
		aud.Play();
	}
}

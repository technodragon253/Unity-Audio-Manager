using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager {
    private static AudioManager _instance;

    public static AudioManager Instance () {
        if (_instance == null) {
            _instance = new AudioManager();
        }
        return _instance;
    }

    //[SerializeField]
    public static SfxContainer musicTracks; //The main music tracks to be played.

    private void Awake() {
        if (_instance != null && _instance != this) {
            Debug.Log("Two Singletons active. May cause issues.");
        }
    }

    public void PlayOneShot(SfxContainer container, Vector3 playPosition) { //Plays a random audio clip from an audio container.
        if (container == null) {
            Debug.LogError("Sfx Container is nonexistent or null.");
            return;
        }
        int random = Random.Range(0, container.NumberOfClips());
        if (container.NumberOfClips() == 0) {
            Debug.LogError("'" + container.name + "' Sfx Container is empty.");
            return;
        }
        GameObject obj;
        obj = new GameObject("Audio Instance");
        obj.AddComponent<AudioPlayable>();
        obj.GetComponent<AudioPlayable>().Setup(container.clips[random], playPosition, container.volume, container.audioMixerGroup);
    }
}

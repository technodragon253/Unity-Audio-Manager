using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[CreateAssetMenu(fileName = "New SfxContainer", menuName = "ScriptableObjects/SfxContainer", order = 1)] //Allows you to make instances of this from the create asset menu.
public class SfxContainer : ScriptableObject
{
    [SerializeField]
    private AudioClip _clip; //List of audio clips.
    public AudioClip clip {
        get {
            return _clip;
        }
        private set {
            _clip = value;
        }
    }
    [SerializeField]
    private List<AudioClip> _clips; //List of audio clips.
    public List<AudioClip> clips {
        get {
            return _clips;
        }
        private set {
            _clips = value;
        }
    }
    [SerializeField] [Range(min:0f, max:1f)] 
    private float _volume = 1f; //Volume variable with a slider.
    public float volume {
        get {
            return _volume;
        }
        private set {
            _volume = value;
        }
    }
    [SerializeField]
    private AudioMixerGroup _audioMixerGroup; //List of audio clips.
    public AudioMixerGroup audioMixerGroup {
        get {
            return _audioMixerGroup;
        }
        private set {
            _audioMixerGroup = value;
        }
    }
    public int NumberOfClips() { //Return the number of clips in the clips array.
        return _clips.ToArray().Length;
    }
}

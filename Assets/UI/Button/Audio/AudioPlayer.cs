using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    [SerializeField]
    AudioClip clip;
    AudioSource source;
    // Start is called before the first frame update
    private void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        source.Play();
    }
}

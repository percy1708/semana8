using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEfectsController : MonoBehaviour
{
    public AudioClip[] _AudioClips;
    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayShotDump()
    {
        _audioSource.PlayOneShot(_AudioClips[0]);
        
        
        
    }

    
}

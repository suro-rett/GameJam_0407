using Unity.VisualScripting;
using UnityEngine;

public class BGM_ouka : MonoBehaviour
{
    public AudioClip soundBGM;

    AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(soundBGM);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Biến lưu trữ audio source
    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;

    // Biến lưu trữ audio clip
    public AudioClip lossClip;
    public AudioClip roiClip;

    public void PlaySFX(AudioClip sfxClip)
    {
        vfxAudioSource.clip = sfxClip;
        vfxAudioSource.PlayOneShot(sfxClip);
    }
}

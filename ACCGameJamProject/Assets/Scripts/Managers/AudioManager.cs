using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public static class AudioManager
{
    private static AudioSource musicAudioSource;
    public static void Init(){
        musicAudioSource = Camera.main.GetComponent<AudioSource>();
    }
    public static async void PlaySound(AudioClip clip){
        Debug.Log("Playing Sound");
        AudioSource audioSource = Camera.main.gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();
        await Task.Delay(((int)Mathf.Ceil(clip.length*1000)));
        GameObject.Destroy(audioSource);
    }
    public static void ReplaceMusic(AudioClip clip){
        musicAudioSource.clip = clip;
        musicAudioSource.Play();
    }
}

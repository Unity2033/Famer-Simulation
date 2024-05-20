using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioManager : MonoBehaviour
{
    public Slider slider;
    public AudioClip [ ] audioClip;

    public AudioSource effectSource;
    public AudioSource scenerySource;

    private void Awake()
    {
        scenerySource.volume = slider.value;
    }

    public void Control(float volume)
    {
        scenerySource.volume = volume;
    }

    public void Sound(int audioValue)
    {
        // PlayOneShot : 동시에 여러 공간에서 사운드를 출력하는 함수
        effectSource.PlayOneShot(audioClip[audioValue]);
    }
}

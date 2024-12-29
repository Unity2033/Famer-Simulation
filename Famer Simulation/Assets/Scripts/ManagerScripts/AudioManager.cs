using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoSingletonManager<AudioManager>
{
    [SerializeField] AudioSource effectSource;
    [SerializeField] AudioSource scenerySource;

    [SerializeField] string [] sceneryName;

    public void Listen(AudioClip clip)
    {
        if (effectSource.isPlaying == false)
        {
            effectSource.PlayOneShot(clip);
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        scenerySource.clip = Resources.Load<AudioClip>(sceneryName[scene.buildIndex]);

        scenerySource.loop = true;
        scenerySource.Play();
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}

using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonManager<T> where T : new()
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
                instance = new T();

            return instance;
        }
    }
}

public class MonoPunSingletonManager<T> : MonoBehaviourPunCallbacks where T : MonoBehaviourPunCallbacks
{
    public static T Instance
    { get; protected set; }

    protected virtual void Awake()
    {
        if (Instance == null)
        {
            Instance = FindFirstObjectByType<T>();

            PhotonView photonView = GetComponent<PhotonView>();
            if(photonView != null && !photonView.IsMine)
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
}

public class MonoSingletonManager<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance
    { get; protected set; }

    protected virtual void Awake()
    {
        if (Instance == null)
        {
            Instance = FindFirstObjectByType<T>();

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
}


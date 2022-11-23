using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : class
{
    public bool DontDestroy;
    [SerializeField] static Singleton<T> _instance;
    public static T Instance
    {
        get
        {
            return _instance as T;
        }
    }
  
    void Awake()
    {
        CheckInstance(this);
        if (DontDestroy)
        {
            DontDestroyOnLoad(gameObject);
        }

        Initialize();
    }

    private static void CheckInstance(Singleton<T> instance)
    {
        if(_instance == null)
        {
            _instance = instance;
        }
        else
        {
            if(_instance != instance)
            {
                Destroy(instance);
                return;
            }
        }
    }
    
    protected virtual void Initialize()
    {
    }

    protected virtual void Shutdown()
    {
    }

    protected virtual void OnDestroy()
    {
        if(_instance == this)
        {
            _instance = null;
            Shutdown();
        }
    }

    protected virtual void OnApplicationQuit()
    {
        if(_instance == this)
        {
            _instance = null;
            Shutdown();
        }
    }
}

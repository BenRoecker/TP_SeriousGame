using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionmanager : MonoBehaviour
{
    [SerializeField] private UIManager uIManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        uIManager.UpScore();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject sculpture;
    // Before the start
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        sculpture.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called once per frame after Update
    private void FixedUpdate()
    {

    }

    // Update is called once per frame after FixedUpdate
    private void LateUpdate()
    {

    }

    // OnDestroy is called before the object is destroyed
    private void OnDestroy()
    {

    }

    // OnEnable is called when the object in enable
    private void OnEnable()
    {

    }

    // OnDisable is called when the object is disable
    private void OnDisable()
    {

    }
}

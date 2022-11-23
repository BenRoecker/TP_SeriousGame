using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager1 : Singleton<SceneManager1>
{
    #region SerializeField
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;
    [SerializeField] private float rotationspeed;
    [SerializeField] private Animation animation;
    [SerializeField] private GameObject cube;
    [SerializeField] private bool isRotate;
    #endregion

    #region private field
    #endregion

    #region Public Field
    public bool IsCubeRotate { get { return isRotate; } set {isRotate = value; } }
    #endregion

    #region private methods
    // Before the start
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        //sculpture.SetActive(false);
        animation.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        animation.enabled = false;
        //sculpture.transform.Rotate(0, speed * Time.deltaTime, 0);
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.Translate(transform.forward*Time.deltaTime*speed);
            animation.enabled = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.Translate(-transform.forward* Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Rotate(0, -Time.deltaTime * rotationspeed, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Rotate(0, Time.deltaTime * rotationspeed, 0);
        }
        if (isRotate)
        {
            cube.transform.Rotate(0, Time.deltaTime * 60, 0);
        }*/
        
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
    #endregion

    #region public method
    public void RotateCube()
    {
        cube.transform.Rotate(0, 60, 0);
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionmanager : MonoBehaviour
{
    [SerializeField] private UIManager uIManager;
    [SerializeField] private int CubeForce;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * Input.GetAxis("Vertical") * CubeForce);
        rb.AddForce(Vector3.right * Input.GetAxis("Horizontal") * CubeForce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag == "ami")
        {
            uIManager.UpScore();
        }
        else if(collision.gameObject.tag == "ennemi")
        {
            uIManager.DownScore();
        }
        
    }

    
}

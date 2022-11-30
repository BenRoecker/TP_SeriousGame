using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _playerAnimator;
    [SerializeField] private int _characterSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Vertical"))
        {
            _playerAnimator.SetBool("IsWalking", false);
        }
        if(Input.GetButtonUp("Vertical"))
        {
            _playerAnimator.SetBool("IsWalking", true);
        }
        transform.Translate(Vector3.forward * (Input.GetAxis("Vertical") * _characterSpeed)*Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            _playerAnimator.SetBool("IsJump", true);
        }
        else
        {
            _playerAnimator.SetBool("IsJump", false);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            _playerAnimator.SetBool("IsAttacking", true);
        }
        else
        {
            _playerAnimator.SetBool("IsAttacking", false);
        }
    }
}
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class Player : MonoBehaviour
{
    [SerializeField] private float speedForward = 5f;
    [SerializeField] private float speedSide = 5f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveForward = Input.GetAxis("Vertical") * speedForward * Time.deltaTime;
        float moveSide = Input.GetAxis("Horizontal") * speedSide * Time.deltaTime;

        transform.Translate(moveSide,0 , moveForward);

    }
}

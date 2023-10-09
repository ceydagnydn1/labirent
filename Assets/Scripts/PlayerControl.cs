using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{

    public float moveSpeed;
    public CharacterController characterController;
    public Transform cam;
    public float lookSensivity;
    public float maxXRot;
    public float minXRot;
    private float curXRot;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //esc tuþuna bastýðnda cursýr gelecektir.
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Look();
    }
    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 dir = transform.right * x + transform.forward * z;
        dir.Normalize();

        dir *= moveSpeed * Time.deltaTime;
        characterController.Move(dir);


    }
    void Look()
    {
        float x = Input.GetAxis("Mouse X") * lookSensivity;
        float y = Input.GetAxis("Mouse Y") * lookSensivity;

        transform.eulerAngles += Vector3.up * x;

        curXRot += y;
        curXRot = Mathf.Clamp(curXRot, minXRot, maxXRot);
        cam.localEulerAngles = new Vector3(-curXRot, 0.0f, 0.0f);
    }
    }
public class hareket : MonoBehaviour
{
    float speed = 1;
    float maxspeed = 15;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 hizeklentisi = playerInput * Time.fixedDeltaTime * speed;
        this.GetComponent<Rigidbody>().AddForce(hizeklentisi);
        this.GetComponent<Rigidbody>().velocity = new Vector3(Mathf.Clamp(this.GetComponent<Rigidbody>().velocity.z, -10, 10), Mathf.Clamp(this.GetComponent<Rigidbody>().velocity.z, -10, 10), Mathf.Clamp(this.GetComponent<Rigidbody>().velocity.z, -10, 10));
    }
}
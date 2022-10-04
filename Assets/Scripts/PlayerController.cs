using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public const string HORIZONTAL = "Horizontal", VERTICAL = "Vertical";

    private float inputTol = 0.2f; // Input tolerance
    private float xInput, yInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        xInput = Input.GetAxisRaw(HORIZONTAL);
        if (Mathf.Abs(xInput) > inputTol)
        {
            Vector3 translation = new Vector3(xInput * speed * Time.deltaTime, 0, 0);
            transform.Translate(translation);
        }
        xInput = Input.GetAxisRaw(VERTICAL);
        if (Mathf.Abs(xInput) > inputTol)
        {
            Vector3 translation = new Vector3( x:0 ,xInput * speed * Time.deltaTime, z:0);
            transform.Translate(translation);
        }
    }

}

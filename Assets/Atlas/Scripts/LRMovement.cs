using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRMovement : MonoBehaviour
{
    private float horizontalInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * speed * horizontalInput * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    private float topBound;
    private float bottomBound;

    // Start is called before the first frame update
    void Start()
    {
        speed = 40f;
        topBound = 30;
        bottomBound = -10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
            // PIZZA TASTES GOOD
        }
        else if (transform.position.z < bottomBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}

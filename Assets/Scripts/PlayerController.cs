using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float playerSpeed;
    public Transform spawnPoint;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, spawnPoint.position, projectilePrefab.transform.rotation);
        }


        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(horizontalInput * playerSpeed * Time.deltaTime, 0, 0);
    }
}

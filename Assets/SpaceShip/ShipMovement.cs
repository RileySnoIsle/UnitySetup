using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

    public float rotateScale;
    public float thrustScale;
    private Rigidbody2D rb2;
    public GameObject Laser;
    public GameObject LaserSpawn;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = rotateScale * Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, 0, -rotation));

        float thrust = thrustScale * Input.GetAxis("Vertical");
        rb2.AddForce(transform.up * thrust);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(Laser, LaserSpawn.transform.position, Quaternion.identity);
            Rigidbody2D rb2b = b.GetComponent<Rigidbody2D>();
            rb2b.AddForce(bulletSpeed * transform.up);
            Destroy(b, 1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public GameObject bala;
    public float speed = 10;
    public Rigidbody2D rb;
    public Transform jugador;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
        
        if ( Input.GetKeyDown (KeyCode.Mouse1))
            {
            disparar(); 
        }
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);
    }
    void disparar()
    {
        GameObject balita = Instantiate(bala, jugador.position, jugador.rotation);
        Rigidbody2D rr = balita.GetComponent<Rigidbody2D>();
        rr.AddForce(jugador.up * speed, ForceMode2D.Impulse);
    }
}

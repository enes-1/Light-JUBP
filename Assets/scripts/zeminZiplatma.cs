using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminZiplatma : MonoBehaviour
{
    public float ZıplamaKuvveti;
    public bool zeminetemasedildi;
    float rasgeledeğer;
    Animator anim;
  


    private void Start() {
        anim = GetComponent<Animator>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
             
             
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 zıplamaVelocity = rb.velocity;
                zıplamaVelocity.y = ZıplamaKuvveti;
                rb.velocity = zıplamaVelocity;

                if (zeminetemasedildi == false)
                {
                    
                    rasgeledeğer = Random.Range(1,6);
                    Yönetici.skorsayısı += rasgeledeğer;
                    zeminetemasedildi = true;

                }
                anim.SetBool("TemasEdildi",true);
                Destroy(gameObject,1f);
            }
            
        }
    }
}   
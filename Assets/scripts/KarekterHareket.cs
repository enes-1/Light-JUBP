using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarekterHareket : MonoBehaviour
{
   public float harekethızı;
private float yatayhareket;

Rigidbody2D rb;

private void Start( ) {
rb =GetComponent<Rigidbody2D>();

}

private void Update() {
	//yatayhareket = Input.GetAxis("Horizontal");
	rb.velocity = new Vector2(yatayhareket*harekethızı*Time.deltaTime,rb.velocity.y);
}

public void sol()
{
	yatayhareket = -1;
}

public void sağ()
{
	yatayhareket = 1;
}

public void dur()
{
	yatayhareket = 0;
}


}

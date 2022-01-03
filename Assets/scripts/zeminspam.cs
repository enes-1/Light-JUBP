using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminspam : MonoBehaviour
{
    public GameObject zeminred;
	
	 Transform tr;

	public int zeminsayısı;

	public float zemingenişlik;

	public float minimumy, maximumy;


	private void Start()
	{
		tr = zeminred.GetComponent<Transform>();
		Vector3 spawnKonumu = new Vector3();
		Vector2 yeniscale = new Vector2();

		for(int i = 0;i<zeminsayısı;i++){
			yeniscale.x = Random.Range(0.9f,1.1f);
			yeniscale.y = Random.Range(0.9f,1.1f);
			tr.localScale = yeniscale;

			spawnKonumu.y += Random.Range(minimumy,maximumy);
			spawnKonumu.x = Random.Range(-zemingenişlik,zemingenişlik);

			Instantiate(zeminred,spawnKonumu,Quaternion.identity);

		}


	}
}

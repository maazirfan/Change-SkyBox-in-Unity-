using UnityEngine;
using System.Collections;

public class Test_Animation_image : MonoBehaviour {


	//to move object from position a to b using this as animation
	public GameObject[] Loci_Block;

	public bool[] animation_image;


	// Use this for initialization
	void Start () 
	{
		
	

	}

	void Update()
	{
		
		if (animation_image[0] == true) 
		{
			Loci_Block[0].transform.Translate (Vector3.back * Time.deltaTime * 5);
		}

		if (animation_image[1] == true) 
		{
			Loci_Block[1].transform.Translate (Vector3.back * Time.deltaTime * 5);
			Loci_Block [2].transform.Translate (Vector3.up * Time.deltaTime * 5);
		}



//		if (Door.transform.position.y > 7f) 
//		{
//			doorIsOpening = false;
//		}
		//it will animate by changing it position 
		// we can used it in any position point x,y,z for cordinate x use Vector3.up 

		if (Loci_Block[0].transform.position.z < 40f) 
		{
			animation_image[0] = false;
		}

		if (Loci_Block[1].transform.position.z < 40f) 
		{
			animation_image[1] = false;
		}

	}


	public void OnClickBtn()
	{
		animation_image[0] = true;
		animation_image[1] = true;
	}

	public void onBack()
	{
		
	}



}

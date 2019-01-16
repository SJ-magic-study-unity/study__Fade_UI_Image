/************************************************************
If you use syphon, make Renderer texture as usual.
When you make a material, attach this texture.

material
	UI/Unlit/Transparent (Simple "Unlit" shader did not work as for alpha)
	Make sure that Tint : a = 255.
	
	Note:
		If you cannot find "UI/Unlit/Transparent" in the shader selection,
		just Re:Boot unity.
		Maybe you can find it now.
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; // need this to use "Image"

/************************************************************
************************************************************/
public class Alpha : MonoBehaviour {
	/****************************************
	****************************************/
	[SerializeField] GameObject GO_img;
	Image img;
	KeyCode Key__Disp_Off	= KeyCode.Alpha0;
	KeyCode Key__Disp_Half	= KeyCode.Alpha1;
	KeyCode Key__Disp_Full	= KeyCode.Alpha2;
	
	
	/****************************************
	****************************************/
	
	/******************************
	******************************/
	void Start () {
		GO_img.SetActive(true);
		img = GO_img.GetComponent<Image>();
		image_on(ref img);
	}
	
	/******************************
	******************************/
	void image_on (ref Image image){
		image.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		image.enabled = true;
	}
	
	/******************************
	******************************/
	void image_off (ref Image image){
		image.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
		image.enabled = false;
	}
	
	/******************************
	******************************/
	void Alpha_off (ref Image image){
		image.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	}
	
	/******************************
	******************************/
	void Alpha_Half (ref Image image){
		image.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
	}
	
	/******************************
	******************************/
	void Alpha_on (ref Image image){
		image.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	}
	
	/******************************
	******************************/
	void Update () {
		/********************
		********************/
		if(Input.GetKeyDown(Key__Disp_Off))			Alpha_off(ref img);
		else if(Input.GetKeyDown(Key__Disp_Half))	Alpha_Half(ref img);
		else if(Input.GetKeyDown(Key__Disp_Full))	Alpha_on(ref img);
		
		
	}
}

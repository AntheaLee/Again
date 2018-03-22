using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add
using UnityEngine.UI;
using UnityEngine.Events;

using System.Runtime.InteropServices;//!

public class clickOk : MonoBehaviour {
	//1.
	//[DllImport("__Internal")];
//	private static extern void clickBtn ();
	Text text;

	// Use this for initialization
	void Start () {
		//2.
		Transform btnObj = transform.Find ("Button");//找物件？
		Transform textObj = transform.Find ("Text");

		Button btn = btnObj.GetComponent<Button> ();
		text = textObj.GetComponent<Text> ();
//		btn.onClick.AddListener (openBtn);
	}


	//3.點擊按鈕讓ios知道的方法 配合12 13 7
//	void openBtn(){
//		clickBtn ();//程式在ios中
//		Debug.Log ("click");
//	}

	//4.接收值の方法 public!
	public void textStr(string pa){
		Debug.Log ("開始papa");
		text.text = pa;

	}


	// Update is called once per frame
	void Update () {
		
	}
}

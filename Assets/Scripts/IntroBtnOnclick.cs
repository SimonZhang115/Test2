using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IntroBtnOnclick : MonoBehaviour {
    public char pageNum;
    public GameObject page;
    public GameObject btnPrint;
    // Use this for initialization
    void Start () {
        Button btn = btnPrint.GetComponent<Button>();
        btn.onClick.AddListener(JumpToIntro);
    }
	
	// Update is called once per frame
	void JumpToIntro () {
        page.GetComponent<Text>().text=pageNum+ page.GetComponent<Text>().text.Substring(1,2);
    }
}

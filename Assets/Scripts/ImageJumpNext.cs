using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageJumpNext : MonoBehaviour {
    public GameObject page;
    public GameObject btnPrint;
    
    // Use this for initialization
    void Start ()
    {
		Button btn = btnPrint.GetComponent<Button>();
        btn.onClick.AddListener(Next_Page);
    }
	
	// Update is called once per frame
	void Next_Page ()
    {
        string a = page.GetComponent<Text>().text;
        char[] pageInfo = a.ToCharArray();
        if(pageInfo[0]==pageInfo[2])
        {
            return;
        }
        GameObject curImage;
        GameObject nxtImage;
        GameObject root;
        root = GameObject.Find("Guide book");
        curImage = GameObject.Find("Image" + pageInfo[0]);
        pageInfo[0]++;
        nxtImage = root.transform.Find("Image" + pageInfo[0]).gameObject;           
        curImage.SetActive(false);
        nxtImage.SetActive(true);
        a = new string(pageInfo);
        page.GetComponent<Text>().text = a;

    }
}

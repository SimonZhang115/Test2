using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageJumpBefore : MonoBehaviour {
    public GameObject page;
    public GameObject btnPrint;
    
    // Use this for initialization
    void Start()
    {
        Button btn = btnPrint.GetComponent<Button>();
        btn.onClick.AddListener(Pre_Page);
    }

    // Update is called once per frame
    void Pre_Page()
    {
        string a = page.GetComponent<Text>().text;
        char[] pageInfo = a.ToCharArray();
        if (pageInfo[0] == '1')
        {
            return;
        }
        GameObject curImage;
        GameObject preImage;
        GameObject root;
        root = GameObject.Find("Guide book");
        curImage = GameObject.Find("Image" + pageInfo[0]);
        pageInfo[0]--;
        preImage = root.transform.Find("Image" + pageInfo[0]).gameObject;
        curImage.SetActive(false);
        preImage.SetActive(true);
        a = new string(pageInfo);
        page.GetComponent<Text>().text = a;

    }
}

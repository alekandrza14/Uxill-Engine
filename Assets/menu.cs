using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject g; 
    List<GameObject> gs = new List<GameObject>();
    public InputField ifd;
    public void Start()
    {
        getWorld();
        Cursor.lockState = CursorLockMode.None;
    }

    public void getWorld()
    {
        for (int i = 0; i < gs.Count; i++)
        {
            gs[i].AddComponent<DELETE>();
        }
        gs.Clear();
        DirectoryInfo di = new DirectoryInfo("worlds");
        for (int i = 0; i < di.GetDirectories().Length; i++)
        {


            // di.GetDirectories()[i].FullName;
            gs.Add(Instantiate(Resources.Load<GameObject>("button"), g.transform));
            gs[i].GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "войти в : " + di.GetDirectories()[i].Name; 
            gs[i].GetComponent<EnterWorld>().path = di.GetDirectories()[i].FullName;
        }
    }
    public void CreateWorld()
    {
        Directory.CreateDirectory("worlds/" + ifd.text);
        getWorld();
    }
}

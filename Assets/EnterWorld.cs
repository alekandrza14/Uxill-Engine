using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldData
{
    static public string path;
}
public class WorldSave
{
    public Vector4[] v4;
    public Vector4[] sv3;
    public string[] mats;
    public Vector4 pv4;
    public Quaternion w, w2,w3, i,i2;

}

public class EnterWorld : MonoBehaviour
{
    public string path;
    public void Enter()
    {
        WorldData.path = path;
        SceneManager.LoadScene("World");
    }
}

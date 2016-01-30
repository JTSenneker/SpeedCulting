using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Text;


public class GameController : MonoBehaviour {

    GameObject target;
    GameObject selves;

    //GameObject[] profiles;

    public TextAsset profileXml;

    List<Dictionary<string, string>> profiles = new List<Dictionary<string, string>>();
    Dictionary<string, string> obj;

    void Awake()
    {
        target = GameObject.Find("ProfileButtons");
        selves = GameObject.Find("ActionButtons");
        getXml();
    }

	// Use this for initialization
	void Start () {
        GameObject.Find("ProfileButtons").SetActive(false);
	}

    public void ToggleButtons()
    {
        target.SetActive(!target.activeSelf);
        selves.SetActive(!selves.activeSelf);
    }

    void getXml()
    {
        XmlDocument profileDoc = new XmlDocument();
        profileDoc.LoadXml(profileXml.text);
        XmlNodeList profileNodes = profileDoc.GetElementsByTagName("profile");

        foreach (XmlNode p in profileNodes)
        {
            XmlNodeList profileContent = p.ChildNodes;
            obj = new Dictionary<string, string>();

            foreach(XmlNode profInfo in profileContent){
                if (profInfo.Name == "name")
                {
                    obj.Add("name", profInfo.InnerText);
                }

                profiles.Add(obj);
            }
        }

        string nameProf;
        profiles[0].TryGetValue("name", out nameProf);

        print(nameProf);
    }

}
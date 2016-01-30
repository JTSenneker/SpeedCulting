using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    GameObject target;
    GameObject selves;
    void Awake()
    {
        target = GameObject.Find("ProfileButtons");
        selves = GameObject.Find("ActionButtons");
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
}

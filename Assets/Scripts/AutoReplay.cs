using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class AutoReplay : MonoBehaviour
    {
        float timer = 0;
        public Text info;
        
     // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Data.score = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }
}
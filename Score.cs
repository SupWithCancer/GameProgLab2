using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;

public class Score : MonoBehaviour
{
    public Transform  Player;
    public TextMeshProUGUI scoreText;
    public float initialZ;

    private void Start()
    {
        initialZ = Player.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        float newZ = Player.position.z - initialZ;
        scoreText.SetText("0");
        scoreText.text = newZ.ToString("0");
    }
}

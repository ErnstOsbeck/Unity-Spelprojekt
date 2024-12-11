using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PongOpponentsScore : MonoBehaviour
{
    public TMP_Text textMeshPro;
    public PongGoalLeft pScore;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        textMeshPro.text = pScore.lScore.ToString();
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PongPlayerScore : MonoBehaviour
{
    public TMP_Text textMeshPro;
    public PongGoalRight pScore;

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
        textMeshPro.text = pScore.rScore.ToString();
    }
}

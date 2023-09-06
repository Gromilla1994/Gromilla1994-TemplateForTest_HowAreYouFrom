using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class RewardHandling : MonoBehaviour
{
    public TextMeshProUGUI rewardText;
    public int _score;

    public string[] variantsRewardStr;
    public int[] variantsRewardInt;

    // Start is called before the first frame update
    void Start()
    {
        _score = PlayerPrefs.GetInt("RightAnswers");
        GetReward();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetReward()
    {
        for(int i = 0; i < variantsRewardStr.Length; i++)
        {
            if(_score > variantsRewardInt[i])
            {
                continue;
            }
            else
            {
                rewardText.text = variantsRewardStr[i];
                break;
            }
        }
    }
}

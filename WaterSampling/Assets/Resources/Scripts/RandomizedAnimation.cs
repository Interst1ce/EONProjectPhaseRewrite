using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizedAnimation : MonoBehaviour
{
    [SerializeField]
    public GameObject Object;
    [SerializeField]
    public StoryManager storymanager;
    [SerializeField]
    public AnimationClip clipA;
    [SerializeField]
    public AnimationClip clipB;
    [SerializeField]
    public int steptoactivate;
    int randomint;
    private bool isrunning = false;

    
    // Update is called once per frame
    void Update()
    {

        if (storymanager.currentStep + 1 == steptoactivate && isrunning == false )
        {
            isrunning = true;
            randomint = Random.Range(0, 4);
            if (randomint == 3)
            {
                Object.GetComponent<Animator>().Play(clipA.name);
                storymanager.steps[storymanager.currentStep].correctChoice = 0;
            }
            if (randomint < 3)
            {
                Object.GetComponent<Animator>().Play(clipB.name);
                storymanager.steps[storymanager.currentStep].correctChoice = 1;
            }


        }
    }
}

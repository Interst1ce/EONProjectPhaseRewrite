using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizedAnimation : MonoBehaviour {
    [SerializeField]
    public GameObject Object;
    [SerializeField]
    public StoryManager storymanager;
    [SerializeField]
    public AnimationClip clipA;
    [SerializeField]
    public AnimationClip clipB;
    [SerializeField]
    public AnimationClip clipAA;
    [SerializeField]
    public int steptoactivate;
    int randomint;
    private bool isrunning = false;


    // Update is called once per frame
    void Update() {

        if (storymanager.currentStep + 1 == steptoactivate && isrunning == false) {
            isrunning = true;
            randomint = Random.Range(0,4);
            if (randomint == 3) {
                storymanager.steps[storymanager.currentStep + 1].animClip = clipA;
                storymanager.steps[storymanager.currentStep + 2].animClip = clipAA;
                storymanager.steps[storymanager.currentStep + 2].question.correctChoice = 0;
            }
            if (randomint < 3) {
                storymanager.steps[storymanager.currentStep + 1].animClip = clipB;
                storymanager.steps[storymanager.currentStep + 2].question.correctChoice = 1;
            }


        }
    }
}

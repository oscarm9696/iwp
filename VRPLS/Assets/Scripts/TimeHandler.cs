using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


//The class which handles time managemnet, such as fastforward, rewing, pause/play
public class TimeHandler : MonoBehaviour
{

    public bool isRewind = false;
    public bool isFastF = false;
    public bool isPause = false;
    public bool isPlay = false;
    public bool isRecording = false;

    public List<Vector3> pos2;
    public List<Vector3> pos1;

    public Transform[] carT;

    public Button playBtn;
    public Button pauseBtn;

    public MoveCar mC;

    public Animator anim1;
    public Animator anim2;

    public Dropdown myDropdown;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
   
      
    }
    private void LateUpdate()
    {
        /*if (isRewind)
        {
            pointerDown();
        }
        else 
        {
            pointerUp();
           // mC.MoveObject();

        }*/
    }


    public void Record()
    {
        isRecording = true;
        pos2.Insert(0, carT[0].position);
        pos1.Insert(0, carT[1].position);
 
    }

    public void Rewind()
    {
        
        Debug.Log("rewind");
        anim1.SetFloat("Direction", -1);
        anim1.Play("Our_Car_Scene_1", -1, float.NegativeInfinity);
        anim2.SetFloat("Direction", -1);
        anim2.Play("Intercepting_Van_Scene_1", -1, float.NegativeInfinity);

    }
   
    public void StopRewind()
    {
        isRewind = false;
    }

    public void FastF()
    {
        isFastF = true;
        anim1.SetFloat("Direction", 1);
        anim1.Play("Our_Car_Scene_1", 1, float.PositiveInfinity);
        anim2.SetFloat("Direction", 1);
        anim2.Play("Intercepting_Van_Scene_1", 1, float.NegativeInfinity);
    }
    public void PauseScene()
    {
        isPause = true;
        pauseBtn.gameObject.SetActive(false);
        playBtn.gameObject.SetActive(true);
        Time.timeScale = 0;

    }
    public void PlayScene()
    {
        isPlay = true;
        pauseBtn.gameObject.SetActive(true);
        playBtn.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void pointerDown()
    {
        Rewind();
        Debug.Log("pointer down");
    }
    public void pointerUp()
    {
        PauseScene();
        Debug.Log("pointer up");
    }


    public void HandleDropDown()
    {
        //myDropdown.AddOptions(List<>)
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class Buttons : MonoBehaviour
{
    private GameObject CButton;
    private GameObject DButton;
    private GameObject EButton;
    private GameObject FButton;
    private GameObject GButton;
    private GameObject AButton;
    private GameObject BButton;
    private GameObject C1Button;

    public GameObject ObjectC, ObjectD, ObjectE, ObjectF, ObjectG, ObjectA, ObjectB, ObjectC1;
    public GameObject ObjectCp, ObjectDp, ObjectEp, ObjectFp, ObjectGp, ObjectAp, ObjectBp, ObjectC1p;

    public AudioSource C3;
    public AudioSource D3;
    public AudioSource E3;
    public AudioSource F3;
    public AudioSource G3;
    public AudioSource A3;
    public AudioSource B3;
    public AudioSource C4;
    // Use this for initialization
    void Start()
    {
        CButton = GameObject.Find("ARButtonC");
        DButton = GameObject.Find("ARButtonD");
        EButton = GameObject.Find("ARButtonE");
        FButton = GameObject.Find("ARButtonF");
        GButton = GameObject.Find("ARButtonG");
        AButton = GameObject.Find("ARButtonA");
        BButton = GameObject.Find("ARButtonB");
        C1Button = GameObject.Find("ARButtonC1");

        C3 = gameObject.AddComponent<AudioSource>();
        D3 = gameObject.AddComponent<AudioSource>();
        E3 = gameObject.AddComponent<AudioSource>();
        F3 = gameObject.AddComponent<AudioSource>();
        G3 = gameObject.AddComponent<AudioSource>();
        A3 = gameObject.AddComponent<AudioSource>();
        B3 = gameObject.AddComponent<AudioSource>();
        C4 = gameObject.AddComponent<AudioSource>();

        VirtualButtonBehaviour[] vbs = transform.GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        }

        ObjectCp.SetActive(false);
        ObjectDp.SetActive(false);
        ObjectEp.SetActive(false);
        ObjectFp.SetActive(false);
        ObjectGp.SetActive(false);
        ObjectAp.SetActive(false);
        ObjectBp.SetActive(false);
        ObjectC1p.SetActive(false);

        //VbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //VbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        //VbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        //MusicSource.clip = MusicClip;


    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        Debug.Log("Button down");
        if (vb.name == "ARButtonC")
        {
            //			Debug.Log ("C Note Pressed!!!");
            //AudioSource Audio_Source = gameObject.AddComponent<AudioSource>();
            //Audio_Source.clip = Resources.Load("C3") as AudioClip;
            //StartCoroutine(LateCall(C3_Light));
            ObjectC.SetActive(false);
            ObjectCp.SetActive(true);
            C3.clip = Resources.Load("C4") as AudioClip;
            C3.Play();
            //Audio_Source.Play();
        }

        if (vb.name == "ARButtonD")
        {
            //			Debug.Log ("D Note Pressed!!!");
            //StartCoroutine(LateCall(D3_Light));
            ObjectD.SetActive(false);
            ObjectDp.SetActive(true);
            D3.clip = Resources.Load("D4") as AudioClip;
            D3.Play();
        }

        if (vb.name == "ARButtonE")
        {
            //			Debug.Log ("E Note Pressed!!!");
            //StartCoroutine(LateCall(E3_Light));
            ObjectE.SetActive(false);
            ObjectEp.SetActive(true);
            E3.clip = Resources.Load("E4") as AudioClip;
            E3.Play();
        }

        if (vb.name == "ARButtonF")
        {
            //			Debug.Log ("F Note Pressed!!!");
            //StartCoroutine(LateCall(F3_Light));
            ObjectF.SetActive(false);
            ObjectFp.SetActive(true);
            F3.clip = Resources.Load("F4") as AudioClip;
            F3.Play();
        }

        if (vb.name == "ARButtonG")
        {
            //			Debug.Log ("G Note Pressed!!!");
            //StartCoroutine(LateCall(G3_Light));
            ObjectG.SetActive(false);
            ObjectGp.SetActive(true);
            G3.clip = Resources.Load("G4") as AudioClip;
            G3.Play();
        }

        if (vb.name == "ARButtonA")
        {
            //			Debug.Log ("A Note Pressed!!!");
            //StartCoroutine(LateCall(A3_Light));
            ObjectA.SetActive(false);
            ObjectAp.SetActive(true);
            A3.clip = Resources.Load("A4") as AudioClip;
            A3.Play();
        }

        if (vb.name == "ARButtonB")
        {
            //			Debug.Log ("B Note Pressed!!!");
            //StartCoroutine(LateCall(B3_Light));
            ObjectB.SetActive(false);
            ObjectBp.SetActive(true);
            B3.clip = Resources.Load("B4") as AudioClip;
            B3.Play();
        }

        if (vb.name == "ARButtonC1")
        {   
            ObjectC1.SetActive(false);
            ObjectC1p.SetActive(true);
            C4.clip = Resources.Load("C5") as AudioClip;
            C4.Play();
        }


    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button up");
        if (vb.name == "ARButtonC")
        {
            //			Debug.Log ("C Note Pressed!!!");
            //AudioSource Audio_Source = gameObject.AddComponent<AudioSource>();
            //Audio_Source.clip = Resources.Load("C3") as AudioClip;
            //StartCoroutine(LateCall(C3_Light));
            ObjectC.SetActive(true);
            ObjectCp.SetActive(false);

            //Audio_Source.Play();
        }

        if (vb.name == "ARButtonD")
        {
            //			Debug.Log ("D Note Pressed!!!");
            //StartCoroutine(LateCall(D3_Light));
            ObjectD.SetActive(true);
            ObjectDp.SetActive(false);

        }

        if (vb.name == "ARButtonE")
        {
            //			Debug.Log ("E Note Pressed!!!");
            //StartCoroutine(LateCall(E3_Light));
            ObjectE.SetActive(true);
            ObjectEp.SetActive(false);
        }

        if (vb.name == "ARButtonF")
        {
            //			Debug.Log ("F Note Pressed!!!");
            //StartCoroutine(LateCall(F3_Light));
            ObjectF.SetActive(true);
            ObjectFp.SetActive(false);
        }

        if (vb.name == "ARButtonG")
        {
            //			Debug.Log ("G Note Pressed!!!");
            //StartCoroutine(LateCall(G3_Light));
            ObjectG.SetActive(true);
            ObjectGp.SetActive(false);
        }

        if (vb.name == "ARButtonA")
        {
            //			Debug.Log ("A Note Pressed!!!");
            //StartCoroutine(LateCall(A3_Light));
            ObjectA.SetActive(true);
            ObjectAp.SetActive(false);

        }

        if (vb.name == "ARButtonB")
        {
            //			Debug.Log ("B Note Pressed!!!");
            //StartCoroutine(LateCall(B3_Light));
            ObjectB.SetActive(true);
            ObjectBp.SetActive(false); ;

        }

        if (vb.name == "ARButtonC1")
        {
            //			Debug.Log ("C Note Pressed!!!");
            //AudioSource Audio_Source = gameObject.AddComponent<AudioSource>();
            //Audio_Source.clip = Resources.Load("C3") as AudioClip;
            //StartCoroutine(LateCall(C3_Light));
            ObjectC1.SetActive(true);
            ObjectC1p.SetActive(false);

            //Audio_Source.Play();
        }

    }
}


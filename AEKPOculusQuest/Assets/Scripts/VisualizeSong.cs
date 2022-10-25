using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizeSong : MonoBehaviour
{
    public bool startGame = false;

    public GameObject C4;
    public GameObject Db4;
    public GameObject D4;
    public GameObject Eb4;
    public GameObject E4;
    public GameObject F4;
    public GameObject Gb4;
    public GameObject G4;
    public GameObject Ab4;
    public GameObject A4;
    public GameObject Bb4;
    public GameObject B4;
    public GameObject C5;
    public GameObject Db5;
    public GameObject D5;
    public GameObject Eb5;
    public GameObject E5;
    public GameObject F5;
    public GameObject Gb5;

    //Color variables
    private Color red;
    private Color green;
    private Color white;

    //tempo: BPM
    private float tempo = 2.0f;

    private float timer;
    private float elapsedTime;
    private float redDuration;
    private float delayStart = 3.0f;

    //note duration
    private float whole_note_sec;
    private float threeQuater_note_sec;
    private float half_note_sec;
    private float quarter_note_sec;
    private float eight_note_sec;
    private float sixteenth_note_sec;

    private SongSequence currentNote;

 
    enum SongSequence
    {
        defaultMode,
        C4,
        Db4,
        D4,
        Eb4,
        E4
    }

    // Start is called before the first frame update
    void Start()
    {

        //init colors
        red = new Color(1.0f, 0.0f, 0.0f);
        green = new Color(0.0f, 1.0f, 0.0f);
        white = new Color(1.0f, 1.0f, 1.0f);

        //init red duration
        redDuration = 1.0f;

        //init note lengths
        whole_note_sec = 60.0f / tempo;
        threeQuater_note_sec = whole_note_sec * 0.75f;
        half_note_sec = whole_note_sec * 0.50f;
        quarter_note_sec = whole_note_sec * 0.25f;
        eight_note_sec = whole_note_sec * 0.125f;
        sixteenth_note_sec = whole_note_sec * 0.0625f;
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentNote)
        {
            case SongSequence.defaultMode:

            if(startGame == true)
                {
                    currentNote = currentNote + 1;
                }
            break;

            case SongSequence.C4:
                controlNoteState(C4, quarter_note_sec);
                break;

            case SongSequence.Db4:
                controlNoteState(Db4, quarter_note_sec); 
                break;

            case SongSequence.D4:
                controlNoteState(D4, quarter_note_sec);
                break;


        }
    }

    void PlayNote(GameObject note, Color color)
    {
        note.GetComponent<Renderer>().material.SetColor("Glass", color);

    }

    private void controlNoteState(GameObject note, float note_sec)
    {

        timer += Time.deltaTime;


        if (timer >= delayStart && timer <= delayStart + note_sec)
        {
            PlayNote(note, green);
            //elapsedTime += delayStart + quarter_note_sec;          
        }

        else if (timer >= delayStart + note_sec && timer <= delayStart + note_sec + redDuration)
        {
            PlayNote(note, red);
            //elapsedTime += delayStart + quarter_note_sec;          
        }

        else if (timer >= delayStart + note_sec + redDuration)
        {

            PlayNote(note, white);
            currentNote = currentNote + 1;
            timer = 0;
        }

    }

    public void initiateGame()
    {
        startGame = true;
    }
}

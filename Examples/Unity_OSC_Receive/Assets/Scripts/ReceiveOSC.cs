using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class ReceiveOSC : MonoBehaviour
{
    public OSC osc;

    //Track name in Ableton
    public string trackName;

    public TMP_Text showMIDI;
    public TMP_Text showBar;
    public TMP_Text showBeat;
    public TMP_Text showAutomation;

    void Start()
    {
        //format OSC adresses
        string midiName = "/MIDI_" + trackName;
        string barName = "/Bar_" + trackName;
        string beatName = "/Beat_" + trackName;
        string automationName = "/AUTOMATION_" + trackName + "_Knob_1";

        osc.SetAddressHandler(midiName, OnReceiveMIDI);
        osc.SetAddressHandler(barName, OnReceiveBar);
        osc.SetAddressHandler(beatName, OnReceiveBeat);
        osc.SetAddressHandler(automationName, OnReceiveAutomation);
    }

    //Live-Device: OSC_MIDI_send
    void OnReceiveMIDI(OscMessage message)
    {
        int pitch = message.GetInt(0);
        int velocity = message.GetInt(1);

        //format Text
        showMIDI.text = "MIDI pitch: " + pitch + ", velocity: " + velocity;
    }

    //Live-Device: OSC_Bar_send
    void OnReceiveBar(OscMessage message)
    {
        int bar = message.GetInt(0);

        //format Text
        showBar.text = "Current Bar: " + bar;
    }

    //Live-Device: OSC_Beat_send
    void OnReceiveBeat(OscMessage message)
    {
        int beat = message.GetInt(0);

        //format Text
        showBeat.text = "Current Beat within one Bar: " + beat;
    }

    //Live-Device: OSC_Automation_send
    void OnReceiveAutomation(OscMessage message)
    {
        float Knob_1 = message.GetFloat(0);

        //format Text
        showAutomation.text = "Knob_1: " + Knob_1;
    }

}

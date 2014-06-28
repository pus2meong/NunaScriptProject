using UnityEngine;
using System.Collections;

public class Emotion{
	public enum Feeling {Happy,Sad,Angry,Frustrated}
	public enum Emoticon {Neutral,Happy,Sad,Angry,Frustrated,FearSurprise}
}

public class NunaScript : MonoBehaviour {
	public Emotion.Feeling Feeling;
	public Emotion.Emoticon Emoticon;
	
	public int Score;
	public byte Minutes;		//Menit
	public byte Seconds;		//Detik
	public int LowScoreParameter;		//Berapa score yang dianggap rendah?
	public byte FastFinishTimeParameter;	//Berapa waktu penyelesaian yang dianggap cepat?
	public float StableClickCorrection;		//Plus Minus antar klik yang masih dianggap stabil. 1000 = 1 detik
	public float FastClickParameter;	//Berapa parameter yang dianggap klik cepat? 1000 = 1 detik
	public int LowClickScoreParameter;		//Berapa nilai klik yang di anggap sebagai score rendah?

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

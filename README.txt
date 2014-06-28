NunaScriptProject
=================

public class Emotion{
  public enum Feeling {Happy,Sad,Angry,Frustrated}
  public enum Emoticon {Neutral,Happy,Sad,Angry,Frustrated,FearSurprise}
}

Untuk membuat parameter emosi lebih "Human Friendly" dari segi penulisan kode, kita menggunakan enum yang dimasukkan sebagai kelas bernama Emotion.

Kelas bernama Emotion memiliki dua komponen enum, Feeling dan Emoticon.
Didalam editor Unity, kedua kelas ini setelah di deklarasikan akan muncul di Inspector. Dari sini kita bisa memilih mana yang akan digunakan.


  public Emotion.Feeling Feeling;
  public Emotion.Emoticon Emoticon;
  
Dua baris kode diatas digunakan untuk mendeklarasikan kelas Emotion dengan komponen Feeling dan Emoticon.
Untuk menghemat kata, kita mendeklarasikan enum Feeling dengan nama yang sama yaitu Feeling. begitu juga dengan Emoticon.


  public int Score;   //Untuk menyimpan Score permainan
	public byte Minutes;		//Untuk menghitung Menit
	public byte Seconds;		//Untuk menghitung Detik
	public int LowScoreParameter;		//Berapa score yang dianggap rendah?
	public byte FastFinishTimeParameter;	//Berapa waktu penyelesaian yang dianggap cepat?
	public float StableClickCorrection;		//Plus Minus antar klik yang masih dianggap stabil. 1000 = 1 detik
	public float FastClickParameter;	//Berapa parameter yang dianggap klik cepat? 1000 = 1 detik
	public int LowClickScoreParameter;		//Berapa nilai klik yang di anggap sebagai score rendah?

LowScoreParameter digunakan untuk menentukan berapa score yang dianggap rendah. Nilainya bisa di edit pada Inspector Unity.

FastFinishTimeParameter digunakan untuk menentukan berapa waktu penyelesaian dari game yang dianggap cepat, ini menggunakan satuan menit. Jadi 1 point = 1 menit

StableClickCorrection digunakan untuk koreksi timing dari jeda antar klik yang dianggap stabil.
Manusia tidak bisa mengklik dengan presisi antara klik pertama dengan klik berikutnya, karena itulah diberikan toleransi.
Variabel ini menggunakan satuan

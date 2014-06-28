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


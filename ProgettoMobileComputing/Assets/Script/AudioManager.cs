using UnityEngine.Audio;
using System;
using UnityEngine;
// using UnityEditor.Timeline.Actions;


public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public AudioClip[] soundtrack;
    public Sound[] swordSounds;
    public Sound[] hurtSounds;
    public Sound[] monsterHurtSounds;
    public AudioSource soundtrackSource;

    public static AudioManager instance;
    
    void Awake(){
        if(instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach(Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

        foreach(Sound s in swordSounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        foreach(Sound s in hurtSounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        foreach(Sound s in monsterHurtSounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    
    void Update(){
        if (!soundtrackSource.isPlaying)
		{
			soundtrackSource.clip = soundtrack[UnityEngine.Random.Range(0, soundtrack.Length)];
			soundtrackSource.Play();
		}
    }
    public void RandomSwordSound(int i){
        string name = swordSounds[i].name;
        Sound s = Array.Find(swordSounds, sound => sound.name == name);
        s.source.Play();
    }

    public void RandomHurtSound(int i){
        string name = hurtSounds[i].name;
        Sound s = Array.Find(hurtSounds, sound => sound.name == name);
        s.source.Play();
    }
    public void RandomMonsterHurtSound(int i){
        string name = monsterHurtSounds[i].name;
        Sound s = Array.Find(monsterHurtSounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Play(string name){
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}

using UnityEngine;

public class FootSteps : MonoBehaviour
{
    [SerializeField]
    public AudioClip[] stoneClips;
    [SerializeField]
    public AudioClip[] mudClips;
    [SerializeField]
    public AudioClip[] grassClips;

    private AudioSource AudioSource;
    private TerrainDetector terrainDetector;

    private void Awake()
    {
        AudioSource = GetComponent<AudioSource>();
        terrainDetector = new TerrainDetector();
    }

     void Step()
    {
        AudioClip clip = GetRandomClip();
        AudioSource.PlayOneShot(clip);
    }

    private AudioClip GetRandomClip()
    {
        int terrainTextureIndex = terrainDetector.GetActiveTerrainTextureIdx(transform.position);

        switch(terrainTextureIndex)
        {
            case 0:
                default:
                return stoneClips[UnityEngine.Random.Range(0, stoneClips.Length)];
            case 1:
                return mudClips[UnityEngine.Random.Range(0, mudClips.Length)];
            case 2:
                return grassClips[UnityEngine.Random.Range(0, grassClips.Length)];
        }
        
    }
}
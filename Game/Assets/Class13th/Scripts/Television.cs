using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
[RequireComponent(typeof(Renderer))]
public class Television : MonoBehaviour
{
    [SerializeField] VideoClip[] videoClips;      // 3개 영상 (0,1,2)
    [SerializeField] int currentIndex = 0;        // 시작 인덱스
    [SerializeField] string materialProperty = "_MainTex"; // URP면 "_BaseMap"

    VideoPlayer vp;
    Renderer screen;

    void Awake()
    {
        vp = GetComponent<VideoPlayer>();
        screen = GetComponent<Renderer>();

        vp.enabled = true;               // 비활성 경고 방지
        vp.playOnAwake = false;
        vp.isLooping = true;

        // 화면으로 출력 설정
        vp.renderMode = VideoRenderMode.MaterialOverride;
        vp.targetMaterialRenderer = screen;
        vp.targetMaterialProperty = materialProperty;
    }

    void Start() => Play(currentIndex);

    public void Play(int index)
    {
        if (videoClips == null || index < 0 || index >= videoClips.Length) return;

        currentIndex = index;
        vp.clip = videoClips[index];

        // 준비 후 재생(블랙 프레임 방지)
        vp.Prepare();
        vp.prepareCompleted -= OnPrepared;
        vp.prepareCompleted += OnPrepared;
    }

    void OnPrepared(VideoPlayer _)
    {
        vp.Play();
    }

    // 테스트용: 1/2/3 키로 채널 전환
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Play(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) Play(1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) Play(2);
    }
}

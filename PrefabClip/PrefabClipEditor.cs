using UnityEditor.Timeline;
using UnityEngine.Timeline;

[CustomTimelineEditor(typeof(PrefabClip))]
public class PrefabClipEditor : ClipEditor
{
    private float _defaultDuration = 1.0f;

    public override void OnCreate(TimelineClip clip, TrackAsset track, TimelineClip clonedFrom)
    {
        base.OnCreate(clip, track, clonedFrom);

        // 作成するClipのDuration
        var createdClipDuration = clip.duration;

        // Unityのデフォルト時間ではない かつ 作ろうとしているClipの時間で無い場合はコピーしたClip
        if (createdClipDuration != TimelineClip.kDefaultClipDurationInSeconds && createdClipDuration != _defaultDuration)
        {
            clip.duration = createdClipDuration;
        }
        else
        {
            // コピーではない新規作成なので設定したい初期時間をSetする
            clip.duration = _defaultDuration;
        }
    }
}

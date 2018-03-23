# Unity-realtime-ini-load
유니티에서 사용 가능한 실시간으로 Ini 파일 값의 변경사항을 감지하고 불러오는 라이브러리입니다.
Ini 파일 위치 및 이름, 섹션, 키를 Inspector창에서 설정 가능합니다.

## 사용방법
```
[SerializeField]
private Vector3Config rotation = new Vector3Config("./Config", "Tutorial.ini", "Cylinder", "Rotation", new Vector3());

private void Update()
{
	transform.Rotate(rotation.Value * Time.deltaTime, Space.Self);
}
```

## 타입 확장 가능
[Vector3 확장](https://github.com/wakeup5/Unity-realtime-ini-load/blob/master/Waker/Realtime-Load-Ini/Scripts/Types/Vector3Config.cs)

## IniFile
[https://stackoverflow.com/questions/217902/reading-writing-an-ini-file#answer-14906422](https://stackoverflow.com/questions/217902/reading-writing-an-ini-file#answer-14906422)

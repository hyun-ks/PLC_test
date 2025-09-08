PLC 래더다이어그램 작성 및 WinForms UI 통합 구성
1. GX Works2에서 래더다이어그램 작성 및 시뮬레이터 설정
래더다이어그램 작성 시 입력(A접점), 출력(코일), 내부릴레이 등을 활용한 논리 설계를 진행.

시뮬레이터에서 Logical Station Number를 1로 설정하여 시뮬레이션 환경 구성.

작성한 래더 프로그램을 컴파일 후 시뮬레이션 실행하여 동작 확인.

2. C# WinForms UI 설계
버튼 2개: "Connect" (PLC 연결), "Disconnect" (PLC 연결 해제)

ON/OFF 버튼 2개: PLC 내부 비트 제어용 (예: 램프 ON/OFF)

상태 표시 레이블: 연결 상태 출력 (예: "Connected", "Disconnected", "Error")

타이머 컨트롤 (Timer) 추가, 인터벌 100ms로 설정
